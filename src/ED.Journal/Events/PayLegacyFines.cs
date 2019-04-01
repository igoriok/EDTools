using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class PayLegacyFines : JournalEvent
    {
        [JsonProperty("Amount")]
        public long Amount { get; set; }

        [JsonProperty("BrokerPercentage")]
        public double BrokerPercentage { get; set; }

        public PayLegacyFines()
            : base(nameof(PayLegacyFines))
        {
        }
    }
}
