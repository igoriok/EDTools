using Newtonsoft.Json;

namespace ED.Journal
{
    public class Influence
    {
        [JsonProperty("SystemAddress")]
        public long SystemAddress { get; set; }

        [JsonProperty("Trend")]
        public string Trend { get; set; }

        [JsonProperty("Influence")]
        public string InfluenceInfluence { get; set; }
    }
}