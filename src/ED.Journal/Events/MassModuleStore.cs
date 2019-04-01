using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class MassModuleStore : JournalEvent
    {
        [JsonProperty("MarketID")]
        public long MarketID { get; set; }

        [JsonProperty("Ship")]
        public string Ship { get; set; }

        [JsonProperty("ShipID")]
        public long ShipID { get; set; }

        [JsonProperty("Items")]
        public Item[] Items { get; set; }

        public MassModuleStore()
            : base(nameof(MassModuleStore))
        {
        }
    }
}
