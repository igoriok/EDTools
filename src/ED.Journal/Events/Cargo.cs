using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ED.Journal.Events
{
    public class Cargo : JournalEvent
    {
        [JsonProperty("Vessel")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Vessel Vessel { get; set; }

        [JsonProperty("Count")]
        public int Count { get; set; }

        [JsonProperty("Inventory")]
        public Inventory[] Inventory { get; set; }

        public Cargo()
            : base(nameof(Cargo))
        {
        }
    }
}