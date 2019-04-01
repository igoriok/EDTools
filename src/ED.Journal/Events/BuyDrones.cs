using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class BuyDrones : JournalEvent
    {
        [JsonProperty("Type")]
        public string Type { get; set; }

        [JsonProperty("Count")]
        public long Count { get; set; }

        [JsonProperty("BuyPrice")]
        public long BuyPrice { get; set; }

        [JsonProperty("TotalCost")]
        public long TotalCost { get; set; }

        public BuyDrones()
            : base(nameof(BuyDrones))
        {
        }
    }
}