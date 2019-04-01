using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class ModuleSwap : JournalEvent
    {
        [JsonProperty("MarketID")]
        public long MarketID { get; set; }

        [JsonProperty("FromSlot")]
        public string FromSlot { get; set; }

        [JsonProperty("ToSlot")]
        public string ToSlot { get; set; }

        [JsonProperty("FromItem")]
        public string FromItem { get; set; }

        [JsonProperty("FromItem_Localised")]
        public string FromItemLocalised { get; set; }

        [JsonProperty("ToItem")]
        public string ToItem { get; set; }

        [JsonProperty("ToItem_Localised")]
        public string ToItemLocalised { get; set; }

        [JsonProperty("Ship")]
        public string Ship { get; set; }

        [JsonProperty("ShipID")]
        public long ShipID { get; set; }

        public ModuleSwap()
            : base(nameof(ModuleSwap))
        {
        }
    }
}
