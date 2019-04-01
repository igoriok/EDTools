using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class FSSDiscoveryScan : JournalEvent
    {
        [JsonProperty("Progress")]
        public float Progress { get; set; }

        [JsonProperty("BodyCount")]
        public int BodyCount { get; set; }

        [JsonProperty("NonBodyCount")]
        public int NonBodyCount { get; set; }

        public FSSDiscoveryScan()
            : base(nameof(FSSDiscoveryScan))
        {
        }
    }
}