using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class PowerplayDefect : JournalEvent
    {
        [JsonProperty("FromPower")]
        public string FromPower { get; set; }

        [JsonProperty("ToPower")]
        public string ToPower { get; set; }

        public PowerplayDefect()
            : base(nameof(PowerplayDefect))
        {
        }
    }
}