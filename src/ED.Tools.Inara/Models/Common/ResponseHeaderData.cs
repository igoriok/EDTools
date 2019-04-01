using Newtonsoft.Json;

namespace ED.Tools.Inara.Models
{
    public class ResponseHeaderData
    {
        [JsonProperty("userID")]
        public string UserID { get; }

        [JsonProperty("userName")]
        public string UserName { get; }

        [JsonConstructor]
        public ResponseHeaderData(string userID, string userName)
        {
            UserID = userID;
            UserName = userName;
        }
    }
}