using Newtonsoft.Json;

namespace ED.Tools.EDSM
{
    public class Request
    {
        [JsonProperty("commanderName")]
        public string CommanderName { get; }

        [JsonProperty("apiKey")]
        public string ApiKey { get; }

        [JsonProperty("fromSoftware")]
        public string FromSoftware { get; }

        [JsonProperty("fromSoftwareVersion")]
        public string FromSoftwareVersion { get; }

        [JsonProperty("message")]
        public string Message { get; }

        [JsonConstructor]
        public Request(string commanderName, string apiKey, string fromSoftware, string fromSoftwareVersion, string message)
        {
            CommanderName = commanderName;
            ApiKey = apiKey;
            FromSoftware = fromSoftware;
            FromSoftwareVersion = fromSoftwareVersion;
            Message = message;
        }
    }
}