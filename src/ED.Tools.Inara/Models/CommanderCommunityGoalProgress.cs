using Newtonsoft.Json;

namespace ED.Tools.Inara.Models
{
    public class CommanderCommunityGoalProgress
    {
        [JsonProperty("communitygoalGameID")]
        public int CommunityGoalGameID { get; }

        [JsonProperty("contribution")]
        public int Contribution { get; }

        [JsonProperty("percentileBand")]
        public int PercentileBand { get; }

        [JsonProperty("percentileBandReward")]
        public int PercentileBandReward { get; }

        [JsonProperty("isTopRank")]
        public bool? IsTopRank { get; }

        [JsonConstructor]
        public CommanderCommunityGoalProgress(int communityGoalGameID, int contribution, int percentileBand, int percentileBandReward, bool? isTopRank = null)
        {
            CommunityGoalGameID = communityGoalGameID;
            Contribution = contribution;
            PercentileBand = percentileBand;
            PercentileBandReward = percentileBandReward;
            IsTopRank = isTopRank;
        }
    }
}