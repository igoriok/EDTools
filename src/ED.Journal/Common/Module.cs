using Newtonsoft.Json;

namespace ED.Journal
{
    public class Module
    {
        [JsonProperty("Slot")]
        public string Slot { get; set; }

        [JsonProperty("Item")]
        public string Item { get; set; }

        [JsonProperty("On")]
        public bool On { get; set; }

        [JsonProperty("Priority")]
        public int Priority { get; set; }

        [JsonProperty("Health")]
        public float Health { get; set; }

        [JsonProperty("Value", NullValueHandling = NullValueHandling.Ignore)]
        public long? Value { get; set; }

        [JsonProperty("AmmoInClip", NullValueHandling = NullValueHandling.Ignore)]
        public int? AmmoInClip { get; set; }

        [JsonProperty("AmmoInHopper", NullValueHandling = NullValueHandling.Ignore)]
        public int? AmmoInHopper { get; set; }

        [JsonProperty("Engineering", NullValueHandling = NullValueHandling.Ignore)]
        public Engineering Engineering { get; set; }
    }
}