using Newtonsoft.Json;

namespace ED.Journal
{
    public class ShipsHere
    {
        [JsonProperty("ShipID")]
        public long ShipID { get; set; }

        [JsonProperty("ShipType")]
        public string ShipType { get; set; }
        
        [JsonProperty("ShipType_Localised", NullValueHandling = NullValueHandling.Ignore)]
        public string ShipTypeLocalised { get; set; }
        
        [JsonProperty("Value")]
        public long Value { get; set; }

        [JsonProperty("Hot")]
        public bool Hot { get; set; }
        
        [JsonProperty("Name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }
    }
}