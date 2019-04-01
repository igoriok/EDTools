using Newtonsoft.Json;

namespace ED.Journal
{
    public class Killer
    {
        [JsonProperty("Name")]
        public string Name { get; set; }
        
        [JsonProperty("Ship")]
        public string Ship { get; set; }
        
        [JsonProperty("Rank")]
        public string Rank { get; set; }
    }
}