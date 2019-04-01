using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class DockingDenied : JournalEvent
    {
        [JsonProperty("StationName")]
        public string StationName { get; set; }

        [JsonProperty("StationType")]
        public string StationType { get; set; }

        [JsonProperty("MarketID")]
        public long MarketID { get; set; }

        [JsonProperty("Reason")]
        public string Reason { get; set; }

        public DockingDenied()
            : base(nameof(DockingDenied))
        {
        }
    }
}