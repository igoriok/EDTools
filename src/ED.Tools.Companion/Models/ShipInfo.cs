using Newtonsoft.Json;

namespace ED.Tools.Companion.Models
{
    public class ShipInfo
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public ShipValue Value { get; set; }

        [JsonProperty("free")]
        public bool Free { get; set; }

        [JsonProperty("station")]
        public StationInfo Station { get; set; }

        [JsonProperty("starsystem")]
        public StarSystem StarSystem { get; set; }
    }
}