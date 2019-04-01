using Newtonsoft.Json;

namespace ED.Journal
{
    public class Reward
    {
        [JsonProperty("Faction")]
        public string Faction { get; set; }

        [JsonProperty("Reward")]
        public long Name { get; set; }
    }
}