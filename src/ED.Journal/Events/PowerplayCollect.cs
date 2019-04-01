using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class PowerplayCollect : JournalEvent
    {
        [JsonProperty("Power")]
        public string Power { get; set; }

        [JsonProperty("Type")]
        public string Type { get; set; }

        [JsonProperty("Type_Localised")]
        public string TypeLocalised { get; set; }

        [JsonProperty("Count")]
        public long Count { get; set; }

        public PowerplayCollect()
            : base(nameof(PowerplayCollect))
        {
        }
    }
}
