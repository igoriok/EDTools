using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class SellExplorationData : JournalEvent
    {
        [JsonProperty("Systems")]
        public string[] Systems { get; set; }

        [JsonProperty("Discovered")]
        public string[] Discovered { get; set; }

        [JsonProperty("BaseValue")]
        public long BaseValue { get; set; }

        [JsonProperty("Bonus")]
        public long Bonus { get; set; }

        [JsonProperty("TotalEarnings")]
        public long TotalEarnings { get; set; }

        public SellExplorationData()
            : base(nameof(SellExplorationData))
        {
        }
    }
}
