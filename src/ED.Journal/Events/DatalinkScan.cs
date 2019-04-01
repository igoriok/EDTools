using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class DatalinkScan : JournalEvent
    {
        [JsonProperty("Message")]
        public string Message { get; set; }

        [JsonProperty("Message_Localised")]
        public string MessageLocalised { get; set; }

        public DatalinkScan()
            : base(nameof(DatalinkScan))
        {
        }
    }
}