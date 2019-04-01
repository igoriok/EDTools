using System.Collections.Generic;
using Newtonsoft.Json;

namespace ED.Tools.Companion.Models
{
    public class Profile
    {
        [JsonProperty("commander")]
        public Commander Commander { get; set; }
        
        [JsonProperty("lastSystem")]
        public StarSystem LastSystem { get; set; }
        
        [JsonProperty("lastStarport")]
        public Station LastStarport { get; set; }
        
        [JsonProperty("ship")]
        public Ship Ship { get; set; }
        
        [JsonProperty("ships")]
        public Dictionary<long, Ship> Ships { get; set; }
    }
}