using Newtonsoft.Json;

namespace ED.Tools.Inara.Models
{
    public class CommanderProfileRequest
    {
        [JsonProperty("searchName")]
        public string SearchName { get; }

        [JsonConstructor]
        public CommanderProfileRequest(string searchName)
        {
            SearchName = searchName;
        }
    }
}