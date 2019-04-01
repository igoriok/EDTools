using Newtonsoft.Json;

namespace ED.Tools.Companion.Models
{
    public class StationInfo
    {
        [JsonProperty("id")]
        public long Id { get; set; }
        
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}