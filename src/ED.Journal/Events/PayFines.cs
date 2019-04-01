using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class PayFines : JournalEvent
    {
        [JsonProperty("Amount")]
        public long Amount { get; set; }

        [JsonProperty("AllFines")]
        public bool AllFines { get; set; }

        [JsonProperty("Faction")]
        public string Faction { get; set; }

        [JsonProperty("ShipID")]
        public long ShipID { get; set; }

        public PayFines()
            : base(nameof(PayFines))
        {
        }
    }
}
