using Newtonsoft.Json;
using System;

namespace ED.Tools.Inara.Models
{
    public abstract class RequestEvent
    {
        [JsonProperty("eventName")]
        public string EventName { get; }

        [JsonProperty("eventTimestamp")]
        public DateTime EventTimestamp { get; }

        [JsonProperty("eventCustomID")]
        public int? EventCustomID { get; }

        [JsonConstructor]
        protected RequestEvent(string eventName, DateTime? eventTimestamp = null, int? eventCustomID = null)
        {
            EventName = eventName;
            EventTimestamp = eventTimestamp ?? DateTime.UtcNow;
            EventCustomID = eventCustomID;
        }
    }
}