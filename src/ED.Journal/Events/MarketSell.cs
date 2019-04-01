using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class MarketSell : JournalEvent
    {
        [JsonProperty("MarketID")]
        public long MarketID { get; set; }

        [JsonProperty("Type")]
        public string Type { get; set; }

        [JsonProperty("Type_Localised")]
        public string TypeLocalised { get; set; }

        [JsonProperty("Count")]
        public long Count { get; set; }

        [JsonProperty("SellPrice")]
        public long SellPrice { get; set; }

        [JsonProperty("TotalSale")]
        public long TotalSale { get; set; }

        [JsonProperty("AvgPricePaid")]
        public long AvgPricePaid { get; set; }

        [JsonProperty("IllegalGoods")]
        public bool? IllegalGoods { get; set; }
        
        [JsonProperty("StolenGoods")]
        public bool? StolenGoods { get; set; }

        [JsonProperty("BlackMarket")]
        public bool? BlackMarket { get; set; }
        
        public MarketSell()
            : base(nameof(MarketSell))
        {
        }
    }
}