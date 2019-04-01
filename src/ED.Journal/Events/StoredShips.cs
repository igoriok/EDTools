using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class StoredShips : JournalEvent
    {
        [JsonProperty("StationName")]
        public string StationName { get; set; }

        [JsonProperty("MarketID")]
        public long MarketID { get; set; }

        [JsonProperty("StarSystem")]
        public string StarSystem { get; set; }

        [JsonProperty("ShipsHere")]
        public ShipsHere[] ShipsHere { get; set; }

        [JsonProperty("ShipsRemote")]
        public ShipsRemote[] ShipsRemote { get; set; }

        public StoredShips()
            : base(nameof(StoredShips))
        {
        }
    }
}
