using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class SendText : JournalEvent
    {
        [JsonProperty("To")]
        public string To { get; set; }

        [JsonProperty("To_Localised")]
        public string ToLocalised { get; set; }

        [JsonProperty("Message")]
        public string Message { get; set; }

        public SendText()
            : base(nameof(SendText))
        {
        }
    }
}
