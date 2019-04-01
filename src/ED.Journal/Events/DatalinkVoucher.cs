using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class DatalinkVoucher : JournalEvent
    {
        [JsonProperty("Reward")]
        public long Reward { get; set; }

        [JsonProperty("VictimFaction")]
        public string VictimFaction { get; set; }

        [JsonProperty("PayeeFaction")]
        public string PayeeFaction { get; set; }

        public DatalinkVoucher()
            : base(nameof(DatalinkVoucher))
        {
        }
    }
}