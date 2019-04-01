using Newtonsoft.Json;
using System.Collections.Generic;

namespace ED.Tools.Inara.Models
{
    public class Response
    {
        [JsonProperty("header")]
        public ResponseHeader Header { get; }

        [JsonProperty("events")]
        public IList<ResponseEvent> Events { get; }

        [JsonConstructor]
        public Response(ResponseHeader header, IList<ResponseEvent> events)
        {
            Header = header;
            Events = events;
        }
    }
}