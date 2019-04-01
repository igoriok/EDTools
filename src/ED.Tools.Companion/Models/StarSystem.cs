using Newtonsoft.Json;

namespace ED.Tools.Companion.Models
{
    public class StarSystem
    {
        [JsonProperty("id")]
        public long Id { get; set; }
        
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("systemaddress")]
        public long? SystemAddress { get; set; }

        [JsonProperty("faction")]
        public string Faction { get; set; }
    }
}