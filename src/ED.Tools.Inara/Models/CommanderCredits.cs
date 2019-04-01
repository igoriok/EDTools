using Newtonsoft.Json;

namespace ED.Tools.Inara.Models
{
    public class CommanderCredits
    {
        [JsonProperty("commanderCredits")]
        public int CommanderCreditsValue { get; }

        [JsonProperty("commanderAssets")]
        public int? CommanderAssets { get; }

        [JsonProperty("commanderLoan")]
        public int? CommanderLoan { get; }

        [JsonConstructor]
        public CommanderCredits(int commanderCredits, int? commanderAssets = null, int? commanderLoan = null)
        {
            CommanderCreditsValue = commanderCredits;
            CommanderAssets = commanderAssets;
            CommanderLoan = commanderLoan;
        }
    }
}