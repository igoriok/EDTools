using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class BuyAmmo : JournalEvent
    {
        [JsonProperty("Cost")]
        public long Cost { get; set; }

        public BuyAmmo()
            : base(nameof(BuyAmmo))
        {
        }
    }
}