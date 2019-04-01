using Newtonsoft.Json;

namespace ED.Journal
{
    public class Material
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Name_Localised")]
        public string NameLocalised { get; set; }
        
        [JsonProperty("Count")]
        public int Count { get; set; }
    }
}