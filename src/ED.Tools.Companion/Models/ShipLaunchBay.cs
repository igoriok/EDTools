using Newtonsoft.Json;

namespace ED.Tools.Companion.Models
{
    public class ShipLaunchBay
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        
        [JsonProperty("locName")]
        public string LocName { get; set; }
        
        [JsonProperty("rebuilds")]
        public int Rebuilds { get; set; }
        
        [JsonProperty("loadout")]
        public string Loadout { get; set; }
        
        [JsonProperty("loadoutName")]
        public string LoadoutName { get; set; }
    }
}