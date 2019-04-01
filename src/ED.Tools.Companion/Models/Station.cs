using System.Collections.Generic;
using Newtonsoft.Json;

namespace ED.Tools.Companion.Models
{
    public class Station : StationInfo
    {
        [JsonProperty("faction")]
        public string Faction { get; set; }
        
        [JsonProperty("minorfaction")]
        public string MinorFaction { get; set; }
        
        [JsonProperty("services")]
        public Dictionary<string, string> Services { get; set; }
    }
}