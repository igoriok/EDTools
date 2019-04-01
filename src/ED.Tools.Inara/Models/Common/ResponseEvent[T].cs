using Newtonsoft.Json;

namespace ED.Tools.Inara.Models
{
    public class ResponseEvent<TResponseEventData> : ResponseEvent
    {
        [JsonProperty("eventData")]
        public TResponseEventData EventData { get; }

        public ResponseEvent(int eventStatus, TResponseEventData eventData, string eventStatusText = null, int? eventCustomID = null)
            : base(eventStatus, eventStatusText, eventCustomID)
        {
            EventData = eventData;
        }
    }
}