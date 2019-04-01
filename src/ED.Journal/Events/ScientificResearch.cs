using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ED.Journal.Events
{
    public class ScientificResearch : JournalEvent
    {
        [JsonProperty("MarketID")]
        public long MarketID { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Category")]
        [JsonConverter(typeof(StringEnumConverter))]
        public MaterialCategory Category { get; set; }

        [JsonProperty("Count")]
        public int Count { get; set; }

        public ScientificResearch()
            : base(nameof(ScientificResearch))
        {
        }
    }
}
