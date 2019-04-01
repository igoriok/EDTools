using Newtonsoft.Json;

namespace ED.Journal
{
    public class MaterialComposition
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Name_Localised", NullValueHandling = NullValueHandling.Ignore)]
        public string NameLocalised { get; set; }

        [JsonProperty("Percent")]
        public double Percent { get; set; }
    }
}