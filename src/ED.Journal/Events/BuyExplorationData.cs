using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class BuyExplorationData : JournalEvent
    {
        [JsonProperty("System")]
        public string System { get; set; }

        [JsonProperty("Cost")]
        public long Cost { get; set; }

        public BuyExplorationData()
            : base(nameof(BuyExplorationData))
        {
        }
    }
}