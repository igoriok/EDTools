using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class ModuleBuy : JournalEvent
    {
        [JsonProperty("Slot")]
        public string Slot { get; set; }

        [JsonProperty("SellItem")]
        public string SellItem { get; set; }

        [JsonProperty("SellItem_Localised")]
        public string SellItemLocalised { get; set; }

        [JsonProperty("SellPrice")]
        public long SellPrice { get; set; }

        [JsonProperty("BuyItem")]
        public string BuyItem { get; set; }

        [JsonProperty("BuyItem_Localised")]
        public string BuyItemLocalised { get; set; }

        [JsonProperty("MarketID")]
        public long MarketID { get; set; }

        [JsonProperty("BuyPrice")]
        public long BuyPrice { get; set; }

        [JsonProperty("Ship")]
        public string Ship { get; set; }

        [JsonProperty("ShipID")]
        public long ShipID { get; set; }

        public ModuleBuy()
            : base(nameof(ModuleBuy))
        {
        }
    }
}
