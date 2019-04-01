using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class PowerplayLeave : JournalEvent
    {
        [JsonProperty("Power")]
        public string Power { get; set; }

        public PowerplayLeave()
            : base(nameof(PowerplayLeave))
        {
        }
    }
}
