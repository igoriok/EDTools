using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class Touchdown : JournalEvent
    {
        [JsonProperty("Latitude")]
        public double Latitude { get; set; }

        [JsonProperty("Longitude")]
        public double Longitude { get; set; }

        [JsonProperty("PlayerControlled")]
        public bool PlayerControlled { get; set; }

        public Touchdown()
            : base(nameof(Touchdown))
        {
        }
    }
}
