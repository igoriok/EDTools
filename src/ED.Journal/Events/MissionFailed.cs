using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class MissionFailed : JournalEvent
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("MissionID")]
        public long MissionID { get; set; }
        
        [JsonProperty("Fine")]
        public long? Fine { get; set; }

        public MissionFailed()
            : base(nameof(MissionFailed))
        {
        }
    }
}
