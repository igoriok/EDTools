using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class ReceiveText : JournalEvent
    {
        [JsonProperty("From")]
        public string From { get; set; }

        [JsonProperty("From_Localised")]
        public string FromLocalised { get; set; }

        [JsonProperty("Message")]
        public string Message { get; set; }

        [JsonProperty("Message_Localised")]
        public string MessageLocalised { get; set; }

        [JsonProperty("Channel")]
        public string Channel { get; set; }

        public ReceiveText()
            : base(nameof(ReceiveText))
        {
        }
    }
}
