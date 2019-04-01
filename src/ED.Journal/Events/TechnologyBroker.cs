using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class TechnologyBroker : JournalEvent
    {
        [JsonProperty("BrokerType")]
        public string BrokerType { get; set; }

        [JsonProperty("MarketID")]
        public long MarketID { get; set; }

        [JsonProperty("ItemsUnlocked")]
        public TechnologyBrokerItem[] ItemsUnlocked { get; set; }

        [JsonProperty("Commodities")]
        public Commodity[] Commodities { get; set; }

        [JsonProperty("Materials")]
        public Commodity[] Materials { get; set; }

        public TechnologyBroker()
            : base(nameof(TechnologyBroker))
        {
        }
    }
}
