using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class EngineerApply : JournalEvent
    {
        [JsonProperty("Engineer")]
        public string Engineer { get; set; }

        [JsonProperty("Blueprint")]
        public string Blueprint { get; set; }

        [JsonProperty("Level")]
        public long Level { get; set; }

        [JsonProperty("Override")]
        public string Override { get; set; }

        public EngineerApply()
            : base(nameof(EngineerApply))
        {
        }
    }
}