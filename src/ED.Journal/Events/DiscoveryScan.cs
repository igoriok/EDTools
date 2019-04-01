using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class DiscoveryScan : JournalEvent
    {
        [JsonProperty("SystemAddress")]
        public long SystemAddress { get; set; }

        [JsonProperty("Bodies")]
        public int Bodies { get; set; }

        public DiscoveryScan()
            : base(nameof(DiscoveryScan))
        {
        }
    }
}