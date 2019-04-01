using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class SellDrones : JournalEvent
    {
        [JsonProperty("Type")]
        public string Type { get; set; }

        [JsonProperty("Count")]
        public long Count { get; set; }

        [JsonProperty("SellPrice")]
        public long SellPrice { get; set; }

        [JsonProperty("TotalSale")]
        public long TotalSale { get; set; }

        public SellDrones()
            : base(nameof(SellDrones))
        {
        }
    }
}