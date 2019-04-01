using Newtonsoft.Json;

namespace ED.Tools.Inara.Models
{
    public class CommanderRankEngineer
    {
        [JsonProperty("engineerName")]
        public string EngineerName { get; }

        [JsonProperty("rankStage")]
        public string RankStage { get; }

        [JsonProperty("rankValue")]
        public int? RankValue { get; }

        [JsonConstructor]
        public CommanderRankEngineer(string engineerName, string rankStage = null, int? rankValue = null)
        {
            EngineerName = engineerName;
            RankStage = rankStage;
            RankValue = rankValue;
        }
    }
}