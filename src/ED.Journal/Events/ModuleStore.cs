using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class ModuleStore : JournalEvent
    {
        [JsonProperty("MarketID")]
        public long MarketID { get; set; }

        [JsonProperty("Slot")]
        public string Slot { get; set; }

        [JsonProperty("StoredItem")]
        public string StoredItem { get; set; }

        [JsonProperty("StoredItem_Localised")]
        public string StoredItemLocalised { get; set; }

        [JsonProperty("Ship")]
        public string Ship { get; set; }

        [JsonProperty("ShipID")]
        public long ShipID { get; set; }

        [JsonProperty("Hot")]
        public bool Hot { get; set; }

        [JsonProperty("EngineerModifications")]
        public string EngineerModifications { get; set; }

        [JsonProperty("Level")]
        public long Level { get; set; }

        [JsonProperty("Quality")]
        public double Quality { get; set; }

        public ModuleStore()
            : base(nameof(ModuleStore))
        {
        }
    }
}
