using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class Passengers : JournalEvent
    {
        [JsonProperty("Manifest")]
        public Passenger[] Manifest { get; set; }

        public Passengers()
            : base(nameof(Passengers))
        {
        }
    }
}
