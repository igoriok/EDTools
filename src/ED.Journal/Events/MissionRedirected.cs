using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class MissionRedirected : JournalEvent
    {
        [JsonProperty("MissionID")]
        public long MissionID { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("NewDestinationStation")]
        public string NewDestinationStation { get; set; }

        [JsonProperty("NewDestinationSystem")]
        public string NewDestinationSystem { get; set; }

        [JsonProperty("OldDestinationStation")]
        public string OldDestinationStation { get; set; }

        [JsonProperty("OldDestinationSystem")]
        public string OldDestinationSystem { get; set; }

        public MissionRedirected()
            : base(nameof(MissionRedirected))
        {
        }
    }
}
