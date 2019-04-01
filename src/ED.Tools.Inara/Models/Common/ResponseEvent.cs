using Newtonsoft.Json;

namespace ED.Tools.Inara.Models
{
    public class ResponseEvent : ResponseBase
    {
        [JsonProperty("eventCustomID")]
        public int? EventCustomID { get; }

        [JsonConstructor]
        public ResponseEvent(int eventStatus, string eventStatusText = null, int? eventCustomID = null)
            : base(eventStatus, eventStatusText)
        {
            EventCustomID = eventCustomID;
        }
    }
}