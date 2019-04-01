using Newtonsoft.Json;

namespace ED.Tools.Inara.Models
{
    public class CommanderRankPilot
    {
        [JsonProperty("rankName")]
        public string RankName { get; }

        [JsonProperty("rankValue")]
        public int? RankValue { get; }

        [JsonProperty("rankProgress")]
        public float? RankProgress { get; }

        [JsonConstructor]
        public CommanderRankPilot(string rankName, int? rankValue = null, float? rankProgress = null)
        {
            RankName = rankName;
            RankValue = rankValue;
            RankProgress = rankProgress;
        }
    }
}