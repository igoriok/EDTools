using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class Missions : JournalEvent
    {
        [JsonProperty("Active")]
        public Mission[] Active { get; set; }

        [JsonProperty("Failed")]
        public Mission[] Failed { get; set; }

        [JsonProperty("Complete")]
        public Mission[] Complete { get; set; }

        public Missions()
            : base(nameof(Missions))
        {
        }
    }
}
