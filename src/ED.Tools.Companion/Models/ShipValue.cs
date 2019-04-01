using Newtonsoft.Json;

namespace ED.Tools.Companion.Models
{
    public class ShipValue
    {
        [JsonProperty("hull")]
        public long Hull { get; set; }
        
        [JsonProperty("modules")]
        public long Modules { get; set; }
        
        [JsonProperty("cargo")]
        public long Cargo { get; set; }
        
        [JsonProperty("total")]
        public long Total { get; set; }
        
        [JsonProperty("unloaned")]
        public long Unloaned { get; set; }
    }
}