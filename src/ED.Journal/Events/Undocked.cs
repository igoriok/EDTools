using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class Undocked : JournalEvent
    {
        [JsonProperty("StationName")]
        public string StationName { get; set; }

        [JsonProperty("StationType")]
        public string StationType { get; set; }

        [JsonProperty("MarketID")]
        public long MarketID { get; set; }

        public Undocked()
            : base(nameof(Undocked))
        {
        }
    }
}