using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class BuyTradeData : JournalEvent
    {
        [JsonProperty("System")]
        public string System { get; set; }

        [JsonProperty("Cost")]
        public long Cost { get; set; }

        public BuyTradeData()
            : base(nameof(BuyTradeData))
        {
        }
    }
}