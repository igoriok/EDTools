using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class Repair : JournalEvent
    {
        [JsonProperty("Item")]
        public string Item { get; set; }

        [JsonProperty("Cost")]
        public long Cost { get; set; }

        public Repair()
            : base(nameof(Repair))
        {
        }
    }
}
