using System.Collections.Generic;
using Newtonsoft.Json;

namespace ED.Tools.Companion.Models
{
    public class ShipModule
    {
        [JsonProperty("module")]
        public Module Module { get; set; }
        
        [JsonProperty("engineer")]
        public Engineer Engineer { get; set; }
        
//        [JsonProperty("specialModifications")]
//        public Dictionary<string, string> SpecialModifications { get; set; }
        
        [JsonProperty("WorkInProgress_modifications")]
        public Dictionary<string, ModuleModification> Modifications { get; set; }
    }
}