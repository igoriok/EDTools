using Newtonsoft.Json;

namespace ED.Tools.Companion.Models
{
    public class ShipHealth
    {
        [JsonProperty("hull")]
        public long Hull { get; set; }
        
        [JsonProperty("shield")]
        public long Shield { get; set; }
        
        [JsonProperty("shieldup")]
        public bool ShieldUp { get; set; }
        
        [JsonProperty("integrity")]
        public long Integrity { get; set; }
        
        [JsonProperty("paintwork")]
        public long Paintwork { get; set; }
    }
}