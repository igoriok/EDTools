using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class USSDrop : JournalEvent
    {
        [JsonProperty("USSType")]
        public string USSType { get; set; }

        [JsonProperty("USSType_Localised")]
        public string USSTypeLocalised { get; set; }

        [JsonProperty("USSThreat")]
        public long USSThreat { get; set; }

        public USSDrop()
            : base(nameof(USSDrop))
        {
        }
    }
}
