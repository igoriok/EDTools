using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class DockingTimeout : JournalEvent
    {
        [JsonProperty("StationName")]
        public string StationName { get; set; }

        [JsonProperty("StationType")]
        public string StationType { get; set; }

        [JsonProperty("MarketID")]
        public long MarketID { get; set; }

        public DockingTimeout()
            : base(nameof(DockingTimeout))
        {
        }
    }
}