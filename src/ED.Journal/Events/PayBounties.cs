using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class PayBounties : JournalEvent
    {
        [JsonProperty("Amount")]
        public long Amount { get; set; }

        [JsonProperty("Faction")]
        public string Faction { get; set; }

        [JsonProperty("Faction_Localised")]
        public string FactionLocalised { get; set; }

        [JsonProperty("ShipID")]
        public long ShipID { get; set; }

        [JsonProperty("BrokerPercentage")]
        public double BrokerPercentage { get; set; }

        public PayBounties()
            : base(nameof(PayBounties))
        {
        }
    }
}
