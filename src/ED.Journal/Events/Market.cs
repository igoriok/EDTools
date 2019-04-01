using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class Market : JournalEvent
    {
        [JsonProperty("MarketID")]
        public long MarketID { get; set; }

        [JsonProperty("StationName")]
        public string StationName { get; set; }

        [JsonProperty("StarSystem")]
        public string StarSystem { get; set; }

        public Market()
            : base(nameof(Market))
        {
        }
    }
}
