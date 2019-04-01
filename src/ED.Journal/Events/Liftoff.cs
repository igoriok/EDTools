using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class Liftoff : JournalEvent
    {
        [JsonProperty("Latitude")]
        public double Latitude { get; set; }

        [JsonProperty("Longitude")]
        public double Longitude { get; set; }

        [JsonProperty("PlayerControlled")]
        public bool PlayerControlled { get; set; }

        public Liftoff()
            : base(nameof(Liftoff))
        {
        }
    }
}
