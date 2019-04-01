using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class MarketBuy : JournalEvent
    {
        [JsonProperty("MarketID")]
        public long MarketID { get; set; }

        [JsonProperty("Type")]
        public string Type { get; set; }

        [JsonProperty("Type_Localised")]
        public string TypeLocalised { get; set; }

        [JsonProperty("Count")]
        public long Count { get; set; }

        [JsonProperty("BuyPrice")]
        public long BuyPrice { get; set; }

        [JsonProperty("TotalCost")]
        public long TotalCost { get; set; }

        public MarketBuy()
            : base(nameof(MarketBuy))
        {
        }
    }
}