using Newtonsoft.Json;

namespace ED.Tools.Inara.Models
{
    public class RequestHeader
    {
        [JsonProperty("appName")]
        public string AppName { get; }

        [JsonProperty("appVersion")]
        public string AppVersion { get; }

        [JsonProperty("APIkey")]
        public string ApiKey { get; }

        [JsonProperty("isDeveloped")]
        public bool IsDeveloped { get; }

        [JsonProperty("commanderName")]
        public string CommanderName { get; }

        [JsonProperty("commanderFrontierID")]
        public string CommanderFrontierID { get; }

        [JsonConstructor]
        public RequestHeader(string appName, string appVersion, string apiKey, bool isDeveloped = false, string commanderName = null, string commanderFrontierID = null)
        {
            AppName = appName;
            AppVersion = appVersion;
            ApiKey = apiKey;
            IsDeveloped = isDeveloped;
            CommanderName = commanderName;
            CommanderFrontierID = commanderFrontierID;
        }
    }
}