using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class RepairAll : JournalEvent
    {
        [JsonProperty("Cost")]
        public long Cost { get; set; }

        public RepairAll()
            : base(nameof(RepairAll))
        {
        }
    }
}
