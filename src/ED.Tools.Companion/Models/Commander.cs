using Newtonsoft.Json;

namespace ED.Tools.Companion.Models
{
    public class Commander
    {
        [JsonProperty("id")]
        public long Id { get; set; }
        
        [JsonProperty("name")]
        public string Name { get; set; }
        
        [JsonProperty("credits")]
        public long Credits { get; set; }
        
        [JsonProperty("debt")]
        public long Debt { get; set; }
        
        [JsonProperty("currentShipId")]
        public long CurrentShipId { get; set; }
        
        [JsonProperty("alive")]
        public bool Alive { get; set; }
        
        [JsonProperty("docked")]
        public bool Docked { get; set; }
        
        [JsonProperty("rank")]
        public Rank Rank { get; set; }
    }
}