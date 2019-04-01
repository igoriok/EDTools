using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class PowerplayJoin : JournalEvent
    {
        [JsonProperty("Power")]
        public string Power { get; set; }

        public PowerplayJoin()
            : base(nameof(PowerplayJoin))
        {
        }
    }
}
