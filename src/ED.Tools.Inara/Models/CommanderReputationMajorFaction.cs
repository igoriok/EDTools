using Newtonsoft.Json;

namespace ED.Tools.Inara.Models
{
    public class CommanderReputationMajorFaction
    {
        [JsonProperty("majorfactionName")]
        public string MajorFactionName { get; }

        [JsonProperty("majorfactionReputation")]
        public float MajorFactionReputation { get; }

        [JsonConstructor]
        public CommanderReputationMajorFaction(string majorFactionName, float majorFactionReputation)
        {
            MajorFactionName = majorFactionName;
            MajorFactionReputation = majorFactionReputation;
        }
    }
}