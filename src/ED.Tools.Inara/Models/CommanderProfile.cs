using Newtonsoft.Json;

namespace ED.Tools.Inara.Models
{
    public class CommanderProfile
    {
        [JsonProperty("userID")]
        public string UserID { get; set; }

        [JsonProperty("userName")]
        public string UserName { get; set; }

        [JsonProperty("commanderName")]
        public string CommanderName { get; set; }
    }
}