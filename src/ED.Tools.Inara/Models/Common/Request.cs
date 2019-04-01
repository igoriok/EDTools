using Newtonsoft.Json;
using System.Collections.Generic;

namespace ED.Tools.Inara.Models
{
    public class Request
    {
        [JsonProperty("header")]
        public RequestHeader Header { get; }

        [JsonProperty("events")]
        public IList<RequestEvent> Events { get; }

        public Request(RequestHeader header)
        {
            Header = header;
            Events = new List<RequestEvent>();
        }
    }
}