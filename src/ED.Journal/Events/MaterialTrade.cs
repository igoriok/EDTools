using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class MaterialTrade : JournalEvent
    {
        [JsonProperty("MarketID")]
        public long MarketID { get; set; }

        [JsonProperty("TraderType")]
        public string TraderType { get; set; }

        [JsonProperty("Paid")]
        public MaterialTradeItem Paid { get; set; }

        [JsonProperty("Received")]
        public MaterialTradeItem Received { get; set; }

        public MaterialTrade()
            : base(nameof(MaterialTrade))
        {
        }
    }
}
