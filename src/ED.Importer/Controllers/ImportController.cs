using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using ED.Importer.Options;
using ED.Journal.Events;
using ED.Journal.Trackers;
using ED.Tools.Companion;
using ED.Tools.Inara;
using ED.Tools.Inara.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace ED.Importer.Controllers
{
    [Authorize]
    [Route("/import")]
    public class ImportController : Controller
    {
        private readonly IMapper _mapper;
        private readonly InaraOptions _inaraOptions;

        public ImportController(IMapper mapper, IOptions<InaraOptions> options)
        {
            _mapper = mapper;
            _inaraOptions = options.Value;
        }

        [Route("inara")]
        public async Task<IActionResult> Inara(CancellationToken cancellationToken)
        {
            var accessToken = await GetAccessToken();

            using (var companion = new CompanionApiClient(accessToken))
            using (var inara = new InaraApiClient())
            {
                var profile = await companion.GetProfileAsync(cancellationToken);
                var journal = await companion.GetJournalAsync(cancellationToken);

                var minorFactionReputation = new MinorFactionReputationTracker();
                var engineers = new EngineerTracker();
                var materials = new MaterialTracker();

                foreach (var @event in journal)
                {
                    minorFactionReputation.Track(@event);
                    engineers.Track(@event);
                    materials.Track(@event);
                }

                var header = new RequestHeader(_inaraOptions.AppName, _inaraOptions.AppVersion, _inaraOptions.ApiKey, _inaraOptions.IsDeveloped, _inaraOptions.CommanderName, _inaraOptions.CommanderFrontierID);

                var request = new Request(header)
                    .SetCommanderInventoryMaterials(materials.Materials.Select(pair => new CommanderInventoryMaterialsItem(pair.Key, pair.Value)).ToArray())
                    //.SetCommanderReputationMinorFaction(minorFactionReputation.Reputation.Where(e => !e.Reputation.Equals(0)).Select(pair => new CommanderReputationMinorFaction(pair.FactionName, (float) Math.Round(pair.Reputation / 100F, 2))).ToArray())
                    .SetCommanderRankEngineer(engineers.Engineers.Select(e => new CommanderRankEngineer(e.Name, e.Progress, e.Rank)).ToArray());

                foreach (var reputation in minorFactionReputation.Reputation)
                {
                    if (reputation.Reputation.Equals(0))
                        continue;

                    request.SetCommanderReputationMinorFaction(reputation.FactionName, (float) Math.Round(reputation.Reputation / 100F, 2), reputation.Timestamp);
                }

                var statistics = journal.OfType<Statistics>().LastOrDefault();
                if (statistics != null)
                {
                    request.SetCommanderGameStatistics(_mapper.Map<CommanderGameStatistics>(statistics));
                }

                var response = await inara.SendAsync(request, cancellationToken);
            }

            return Ok();
        }

        private Task<string> GetAccessToken()
        {
            return HttpContext.GetTokenAsync("access_token");
        }
    }
}