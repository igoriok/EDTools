using Newtonsoft.Json;

namespace ED.Journal
{
    public class Inventory
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Name_Localised", NullValueHandling = NullValueHandling.Ignore)]
        public string NameLocalised { get; set; }

        [JsonProperty("Count")]
        public int Count { get; set; }

        [JsonProperty("Stolen")]
        public int Stolen { get; set; }
    }
}