using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class Reputation : JournalEvent
    {
        [JsonProperty("Empire")]
        public int Empire { get; set; }

        [JsonProperty("Federation")]
        public int Federation { get; set; }

        [JsonProperty("Independent")]
        public int Independent { get; set; }

        [JsonProperty("Alliance")]
        public int Alliance { get; set; }

        public Reputation()
            : base(nameof(Reputation))
        {
        }
    }
}
