using Newtonsoft.Json;

namespace ED.Journal
{
    public class SystemFaction
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("FactionState")]
        public string FactionState { get; set; }
    }
}