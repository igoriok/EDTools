using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class EngineerContribution : JournalEvent
    {
        [JsonProperty("Engineer")]
        public string Engineer { get; set; }

        [JsonProperty("EngineerID")]
        public long EngineerID { get; set; }
        
        [JsonProperty("Type")]
        public string Type { get; set; }

        [JsonProperty("Commodity")]
        public string Commodity { get; set; }
        
        [JsonProperty("Material")]
        public string Material { get; set; }

        [JsonProperty("Faction")]
        public string Faction { get; set; }
        
        [JsonProperty("Quantity")]
        public int Quantity { get; set; }

        [JsonProperty("TotalQuantity")]
        public int TotalQuantity { get; set; }

        public EngineerContribution()
            : base(nameof(EngineerContribution))
        {
        }
    }
}
