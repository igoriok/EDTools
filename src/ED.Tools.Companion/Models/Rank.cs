using Newtonsoft.Json;

namespace ED.Tools.Companion.Models
{
    public class Rank
    {
        [JsonProperty("combat")]
        public int Combat { get; set; }
        
        [JsonProperty("trade")]
        public int Trade { get; set; }
        
        [JsonProperty("explore")]
        public int Explore { get; set; }
        
        [JsonProperty("crime")]
        public int Crime { get; set; }
        
        [JsonProperty("service")]
        public int Service { get; set; }
        
        [JsonProperty("empire")]
        public int Empire { get; set; }
        
        [JsonProperty("federation")]
        public int Federation { get; set; }
        
        [JsonProperty("power")]
        public int Power { get; set; }
        
        [JsonProperty("cqc")]
        public int CQC { get; set; }
    }
}