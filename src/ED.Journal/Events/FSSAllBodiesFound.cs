using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class FSSAllBodiesFound : JournalEvent
    {
        [JsonProperty("SystemName")]
        public string SystemName { get; set; }

        [JsonProperty("SystemAddress")]
        public long SystemAddress { get; set; }

        [JsonProperty("Count")]
        public long Count { get; set; }

        public FSSAllBodiesFound()
            : base(nameof(FSSAllBodiesFound))
        {
        }
    }
}