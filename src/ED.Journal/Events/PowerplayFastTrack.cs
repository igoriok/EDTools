using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class PowerplayFastTrack : JournalEvent
    {
        [JsonProperty("Power")]
        public string Power { get; set; }

        [JsonProperty("Cost")]
        public long Cost { get; set; }

        public PowerplayFastTrack()
            : base(nameof(PowerplayFastTrack))
        {
        }
    }
}
