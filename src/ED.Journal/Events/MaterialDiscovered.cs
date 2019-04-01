using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ED.Journal.Events
{
    public class MaterialDiscovered : JournalEvent
    {
        [JsonProperty("Category")]
        [JsonConverter(typeof(StringEnumConverter))]
        public MaterialCategory Category { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Name_Localised")]
        public string NameLocalised { get; set; }

        [JsonProperty("DiscoveryNumber")]
        public long DiscoveryNumber { get; set; }

        public MaterialDiscovered()
            : base(nameof(MaterialDiscovered))
        {
        }
    }
}