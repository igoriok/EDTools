using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class ModuleSellRemote : JournalEvent
    {
        [JsonProperty("StorageSlot")]
        public long StorageSlot { get; set; }

        [JsonProperty("SellItem")]
        public string SellItem { get; set; }

        [JsonProperty("SellItem_Localised")]
        public string SellItemLocalised { get; set; }

        [JsonProperty("ServerId")]
        public long ServerId { get; set; }

        [JsonProperty("SellPrice")]
        public long SellPrice { get; set; }

        [JsonProperty("Ship")]
        public string Ship { get; set; }

        [JsonProperty("ShipID")]
        public long ShipID { get; set; }

        public ModuleSellRemote()
            : base(nameof(ModuleSellRemote))
        {
        }
    }
}
