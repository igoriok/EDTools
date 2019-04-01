using Newtonsoft.Json;

namespace ED.Tools.Inara.Models
{
    public class CommanderPermit
    {
        [JsonProperty("starsystemName")]
        public string StarSystemName { get; }

        [JsonConstructor]
        public CommanderPermit(string starSystemName)
        {
            StarSystemName = starSystemName;
        }
    }
}