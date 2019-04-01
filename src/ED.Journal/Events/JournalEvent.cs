using System;
using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class JournalEvent
    {
        [JsonProperty("event")]
        public string Event { get; }

        [JsonProperty("timestamp")]
        public DateTime Timestamp { get; set; }
        
        [JsonIgnore]
        public string Source { get; set; }

        [JsonConstructor]
        public JournalEvent(string @event)
        {
            Event = @event;
        }
    }
}