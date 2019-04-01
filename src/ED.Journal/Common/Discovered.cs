using Newtonsoft.Json;

namespace ED.Journal
{
    public class Discovered
    {
        [JsonProperty("SystemName")]
        public string SystemName { get; set; }

        [JsonProperty("NumBodies")]
        public int NumBodies { get; set; }
    }
}