using Newtonsoft.Json;

namespace ED.Tools.Inara.Models
{
    public class ResponseHeader : ResponseBase
    {
        [JsonProperty("eventData")]
        public ResponseHeaderData EventData { get; }

        [JsonConstructor]
        public ResponseHeader(int eventStatus, ResponseHeaderData eventData, string eventStatusText = null)
            : base(eventStatus, eventStatusText)
        {
            EventData = eventData;
        }
    }
}