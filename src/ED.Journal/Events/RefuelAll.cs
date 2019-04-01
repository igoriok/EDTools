using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class RefuelAll : JournalEvent
    {
        [JsonProperty("Cost")]
        public long Cost { get; set; }

        [JsonProperty("Amount")]
        public double Amount { get; set; }

        public RefuelAll()
            : base(nameof(RefuelAll))
        {
        }
    }
}
