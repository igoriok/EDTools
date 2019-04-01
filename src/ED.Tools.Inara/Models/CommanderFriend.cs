using Newtonsoft.Json;

namespace ED.Tools.Inara.Models
{
    public class CommanderFriend
    {
        [JsonProperty("commanderName")]
        public string CommanderName { get; }

        [JsonProperty("gamePlatform")]
        public string GamePlatform { get; }

        [JsonConstructor]
        public CommanderFriend(string commanderName, string gamePlatform)
        {
            CommanderName = commanderName;
            GamePlatform = gamePlatform;
        }
    }
}