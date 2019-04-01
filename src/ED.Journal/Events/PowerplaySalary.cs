using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class PowerplaySalary : JournalEvent
    {
        [JsonProperty("Power")]
        public string Power { get; set; }

        [JsonProperty("Amount")]
        public long Amount { get; set; }

        public PowerplaySalary()
            : base(nameof(PowerplaySalary))
        {
        }
    }
}
