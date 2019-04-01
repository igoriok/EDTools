using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ED.Journal.Events
{
    public class MaterialCollected : JournalEvent
    {
        [JsonProperty("Category")]
        [JsonConverter(typeof(StringEnumConverter))]
        public MaterialCategory Category { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Name_Localised")]
        public string NameLocalised { get; set; }

        [JsonProperty("Count")]
        public int Count { get; set; }

        public MaterialCollected()
            : base(nameof(MaterialCollected))
        {
        }
    }
}