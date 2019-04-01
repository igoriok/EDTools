using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class RedeemVoucher : JournalEvent
    {
        [JsonProperty("Type")]
        public string Type { get; set; }

        [JsonProperty("Amount")]
        public long Amount { get; set; }

        [JsonProperty("Factions")]
        public RedeemVoucherFaction[] Factions { get; set; }

        public RedeemVoucher()
            : base(nameof(RedeemVoucher))
        {
        }
    }
}