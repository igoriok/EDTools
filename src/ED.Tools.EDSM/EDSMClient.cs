using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using ED.Journal.Events;
using Newtonsoft.Json;

namespace ED.Tools.EDSM
{
    public class EDSMClient : IDisposable
    {
        private readonly HttpClient _client;

        public EDSMClient()
        {
            _client = new HttpClient
            {
                BaseAddress = new Uri("https://www.edsm.net/")
            };
        }

        public async Task<string[]> GetDiscardEventsAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            var httpResponse = await _client.GetAsync("api-journal-v1/discard", cancellationToken);

            httpResponse.EnsureSuccessStatusCode();

            var content = await httpResponse.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<string[]>(content);
        }
        
        public async Task PostJournalAsync(string[] events)
        {
            var httpResponse = await _client.PostAsync("api-journal-v1", new StringContent(""));

            httpResponse.EnsureSuccessStatusCode();
        }

        public void Dispose()
        {
            _client.Dispose();
        }
    }
}