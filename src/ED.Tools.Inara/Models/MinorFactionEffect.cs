using Newtonsoft.Json;

namespace ED.Tools.Inara.Models
{
    public class MinorFactionEffect
    {
        [JsonProperty("minorfactionName")]
        public string MinorFactionName { get; }

        [JsonProperty("influenceGain")]
        public string InfluenceGain { get; }

        [JsonProperty("reputationGain")]
        public string ReputationGain { get; }

        [JsonConstructor]
        public MinorFactionEffect(string minorFactionName, string influenceGain, string reputationGain)
        {
            MinorFactionName = minorFactionName;
            InfluenceGain = influenceGain;
            ReputationGain = reputationGain;
        }
    }
}