using Newtonsoft.Json;

namespace ED.Journal
{
    public class Parent
    {
        [JsonProperty("Null")]
        public long? Null { get; set; }

        [JsonProperty("Star")]
        public long? Star { get; set; }

        [JsonProperty("Planet")]
        public long? Planet { get; set; }

        [JsonProperty("Ring")]
        public long? Ring { get; set; }
    }
}