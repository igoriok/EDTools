using System;
using Newtonsoft.Json;

namespace ED.Tools.Inara.Models
{
    public class RequestEvent<TRequestEventData, TResponseEventData> : RequestEvent<TRequestEventData>
    {
        [JsonConstructor]
        public RequestEvent(string eventName, TRequestEventData eventData, DateTime? eventTimestamp = null, int? eventCustomID = null)
            : base(eventName, eventData, eventTimestamp, eventCustomID)
        {
        }
    }
}