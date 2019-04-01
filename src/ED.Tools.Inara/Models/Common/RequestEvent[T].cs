using System;
using Newtonsoft.Json;

namespace ED.Tools.Inara.Models
{
    public class RequestEvent<TRequestEventData> : RequestEvent
    {
        [JsonProperty("eventData")]
        public TRequestEventData EventData { get; }

        [JsonConstructor]
        public RequestEvent(string eventName, TRequestEventData eventData, DateTime? eventTimestamp = null, int? eventCustomID = null)
            : base(eventName, eventTimestamp, eventCustomID)
        {
            EventData = eventData;
        }
    }
}