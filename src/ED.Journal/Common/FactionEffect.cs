using Newtonsoft.Json;

namespace ED.Journal
{
    public class FactionEffect
    {
        [JsonProperty("Faction")]
        public string Faction { get; set; }

        [JsonProperty("Effects")]
        public Effect[] Effects { get; set; }

        [JsonProperty("Influence")]
        public Influence[] Influence { get; set; }

        [JsonProperty("ReputationTrend")]
        public string ReputationTrend { get; set; }

        [JsonProperty("Reputation")]
        public string Reputation { get; set; }
    }
}