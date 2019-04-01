using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class Materials : JournalEvent
    {
        [JsonProperty("Raw")]
        public Material[] Raw { get; set; }

        [JsonProperty("Manufactured")]
        public Material[] Manufactured { get; set; }

        [JsonProperty("Encoded")]
        public Material[] Encoded { get; set; }

        public Materials()
            : base(nameof(Materials))
        {
        }
    }
}
