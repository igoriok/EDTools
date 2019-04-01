using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class StoredModules : JournalEvent
    {
        [JsonProperty("MarketID")]
        public long MarketID { get; set; }

        [JsonProperty("StationName")]
        public string StationName { get; set; }

        [JsonProperty("StarSystem")]
        public string StarSystem { get; set; }

        [JsonProperty("Items")]
        public StoredModuleItem[] Items { get; set; }

        public StoredModules()
            : base(nameof(StoredModules))
        {
        }
    }
}
