using Newtonsoft.Json;
using System;

namespace ED.Tools.Inara.Models
{
    public class CommunityGoal
    {
        [JsonProperty("communitygoalGameID")]
        public int CommunityGoalGameID { get; }

        [JsonProperty("communitygoalName")]
        public string CommunityGoalName { get; }

        [JsonProperty("starsystemName")]
        public string StarSystemName { get; }

        [JsonProperty("stationName")]
        public string StationName { get; }

        [JsonProperty("goalExpiry")]
        public DateTime GoalExpiry { get; }

        [JsonProperty("tierReached")]
        public int? TierReached { get; }

        [JsonProperty("tierMax")]
        public int? TierMax { get; }

        [JsonProperty("topRankSize")]
        public int? TopRankSize { get; }

        [JsonProperty("isCompleted")]
        public bool? IsCompleted { get; }

        [JsonProperty("contributorsNum")]
        public int? ContributorsNum { get; }

        [JsonProperty("contributionsTotal")]
        public int? ContributionsTotal { get; }

        [JsonProperty("completionBonus")]
        public string CompletionBonus { get; }

        [JsonConstructor]
        public CommunityGoal(
            int communityGoalGameID, string communityGoalName, string starSystemName, string stationName,
            DateTime goalExpiry, int? tierReached = null, int? tierMax = null, int? topRankSize = null, bool? isCompleted = null,
            int? contributorsNum = null, int? contributionsTotal = null, string completionBonus = null)
        {
            CommunityGoalGameID = communityGoalGameID;
            CommunityGoalName = communityGoalName;
            StarSystemName = starSystemName;
            StationName = stationName;
            GoalExpiry = goalExpiry;
            TierReached = tierReached;
            TierMax = tierMax;
            TopRankSize = topRankSize;
            IsCompleted = isCompleted;
            ContributorsNum = contributorsNum;
            ContributionsTotal = contributionsTotal;
            CompletionBonus = completionBonus;
        }
    }
}