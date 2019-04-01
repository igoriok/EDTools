using Newtonsoft.Json;

namespace ED.Journal
{
    public class StationFaction
    {
        [JsonProperty("Name")]
        public string Name { get; set; }
        
        [JsonProperty("FactionState")]
        public string FactionState { get; set; }
    }
}