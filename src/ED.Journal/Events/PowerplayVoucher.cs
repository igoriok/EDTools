using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class PowerplayVoucher : JournalEvent
    {
        [JsonProperty("Power")]
        public string Power { get; set; }

        [JsonProperty("Systems")]
        public string[] Systems { get; set; }

        public PowerplayVoucher()
            : base(nameof(PowerplayVoucher))
        {
        }
    }
}
