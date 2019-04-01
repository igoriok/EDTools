using System.Collections.Generic;
using Newtonsoft.Json;

namespace ED.Tools.Companion.Models
{
    public class Ship : ShipInfo
    {
        [JsonProperty("alive")]
        public bool Alive { get; set; }
        
        [JsonProperty("health")]
        public ShipHealth Health { get; set; }
        
        [JsonProperty("cockpitBreached")]
        public bool CockpitBreached { get; set; }
        
        [JsonProperty("oxygenRemaining")]
        public long OxygenRemaining { get; set; }
        
        [JsonProperty("modules")]
        public Dictionary<string, ShipModule> Modules { get; set; }
        
        [JsonProperty("launchBays")]
        public Dictionary<string, Dictionary<string, ShipLaunchBay>> LaunchBays { get; set; }
    }
}