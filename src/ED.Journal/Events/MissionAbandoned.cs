using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class MissionAbandoned : JournalEvent
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("MissionID")]
        public long MissionID { get; set; }
        
        [JsonProperty("Fine")]
        public long? Fine { get; set; }

        public MissionAbandoned()
            : base(nameof(MissionAbandoned))
        {
        }
    }
}
