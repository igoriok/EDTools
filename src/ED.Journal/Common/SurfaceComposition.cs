using Newtonsoft.Json;

namespace ED.Journal
{
    public class SurfaceComposition
    {
        [JsonProperty("Ice")]
        public float Ice { get; set; }

        [JsonProperty("Rock")]
        public float Rock { get; set; }

        [JsonProperty("Metal")]
        public float Metal { get; set; }
    }
}