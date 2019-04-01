using Newtonsoft.Json;

namespace ED.Tools.Inara.Models
{
    public class CommanderRankPower
    {
        [JsonProperty("powerName")]
        public string PowerName { get; }

        [JsonProperty("rankValue")]
        public int RankValue { get; }

        [JsonConstructor]
        public CommanderRankPower(string powerName, int rankValue)
        {
            PowerName = powerName;
            RankValue = rankValue;
        }
    }
}