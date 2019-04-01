using Newtonsoft.Json;

namespace ED.Tools.Inara.Models
{
    public class CommanderReputationMinorFaction
    {
        [JsonProperty("minorfactionName")]
        public string MinorFactionName { get; }

        [JsonProperty("minorfactionReputation")]
        public float MinorFactionReputation { get; }

        [JsonConstructor]
        public CommanderReputationMinorFaction(string minorFactionName, float minorFactionReputation)
        {
            MinorFactionName = minorFactionName;
            MinorFactionReputation = minorFactionReputation;
        }
    }
}