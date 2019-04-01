using Newtonsoft.Json;

namespace ED.Tools.Inara.Models
{
    public class ResponseBase
    {
        [JsonProperty("eventStatus")]
        public int EventStatus { get; }

        [JsonProperty("eventStatusText")]
        public string EventStatusText { get; }

        public ResponseBase(int eventStatus, string eventStatusText = null)
        {
            EventStatus = eventStatus;
            EventStatusText = eventStatusText;
        }
    }
}