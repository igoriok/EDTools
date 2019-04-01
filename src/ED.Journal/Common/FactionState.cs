using Newtonsoft.Json;

namespace ED.Journal
{
    public class FactionState
    {
        [JsonProperty("State")]
        public string State { get; set; }
        
        [JsonProperty("Trend")]
        public int? Trend { get; set; }
    }
}