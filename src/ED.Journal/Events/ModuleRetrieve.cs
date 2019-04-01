using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class 
        ModuleRetrieve : JournalEvent
    {
        [JsonProperty("MarketID")]
        public long MarketID { get; set; }

        [JsonProperty("Slot")]
        public string Slot { get; set; }

        [JsonProperty("RetrievedItem")]
        public string RetrievedItem { get; set; }

        [JsonProperty("RetrievedItem_Localised")]
        public string RetrievedItemLocalised { get; set; }

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

        [JsonProperty("SwapOutItem")]
        public string SwapOutItem { get; set; }

        [JsonProperty("SwapOutItem_Localised")]
        public string SwapOutItemLocalised { get; set; }

        public ModuleRetrieve()
            : base(nameof(ModuleRetrieve))
        {
        }
    }
}
