using Newtonsoft.Json;

namespace ED.Tools.Companion.Models
{
    public class MarketEconomy
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        
        [JsonProperty("proportion")]
        public float Proportion { get; set; }
    }
}