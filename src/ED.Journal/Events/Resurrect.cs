using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class Resurrect : JournalEvent
    {
        [JsonProperty("Option")]
        public string Option { get; set; }

        [JsonProperty("Cost")]
        public long Cost { get; set; }

        [JsonProperty("Bankrupt")]
        public bool Bankrupt { get; set; }

        public Resurrect()
            : base(nameof(Resurrect))
        {
        }
    }
}
