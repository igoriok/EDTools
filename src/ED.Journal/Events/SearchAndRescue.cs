using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class SearchAndRescue : JournalEvent
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Count")]
        public long Count { get; set; }

        [JsonProperty("Reward")]
        public long Reward { get; set; }

        public SearchAndRescue()
            : base(nameof(SearchAndRescue))
        {
        }
    }
}
