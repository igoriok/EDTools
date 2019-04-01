using Newtonsoft.Json;

namespace ED.Journal
{
    public class RedeemVoucherFaction
    {
        [JsonProperty("Faction")]
        public string Faction { get; set; }

        [JsonProperty("Amount")]
        public long Amount { get; set; }
    }
}