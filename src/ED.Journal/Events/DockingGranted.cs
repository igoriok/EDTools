using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class DockingGranted : JournalEvent
    {
        [JsonProperty("StationName")]
        public string StationName { get; set; }

        [JsonProperty("StationType")]
        public string StationType { get; set; }

        [JsonProperty("MarketID")]
        public long MarketID { get; set; }

        [JsonProperty("LandingPad")]
        public int LandingPad { get; set; }

        public DockingGranted()
            : base(nameof(DockingGranted))
        {
        }
    }
}