using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class MultiSellExplorationData : JournalEvent
    {
        [JsonProperty("Discovered")]
        public Discovered[] Discovered { get; set; }

        [JsonProperty("BaseValue")]
        public long BaseValue { get; set; }

        [JsonProperty("Bonus")]
        public long Bonus { get; set; }

        [JsonProperty("TotalEarnings")]
        public long TotalEarnings { get; set; }

        public MultiSellExplorationData()
            : base(nameof(MultiSellExplorationData))
        {
        }
    }
}
