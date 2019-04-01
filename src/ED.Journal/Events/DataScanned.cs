using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class DataScanned : JournalEvent
    {
        [JsonProperty("Type")]
        public string Type { get; set; }

        [JsonProperty("Type_Localised")]
        public string TypeLocalised { get; set; }

        public DataScanned()
            : base(nameof(DataScanned))
        {
        }
    }
}