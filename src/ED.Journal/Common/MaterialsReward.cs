using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ED.Journal
{
    public class MaterialsReward
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Name_Localised")]
        public string NameLocalised { get; set; }

        [JsonProperty("Category")]
        [JsonConverter(typeof(StringEnumConverter))]
        public MaterialCategory Category { get; set; }

        [JsonProperty("Category_Localised")]
        public string CategoryLocalised { get; set; }

        [JsonProperty("Count")]
        public int Count { get; set; }
    }
}