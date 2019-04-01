using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ED.Journal.Events
{
    public class MaterialDiscarded : JournalEvent
    {
        [JsonProperty("Category")]
        [JsonConverter(typeof(StringEnumConverter))]
        public MaterialCategory Category { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Count")]
        public int Count { get; set; }

        public MaterialDiscarded()
            : base(nameof(MaterialDiscarded))
        {
        }
    }
}