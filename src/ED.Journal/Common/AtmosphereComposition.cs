using Newtonsoft.Json;

namespace ED.Journal
{
    public class AtmosphereComposition
    {
        [JsonProperty("Name")]
        public string Name { get; set; }
        
        [JsonProperty("Percent")]
        public float Percent { get; set; }
    }
}