using Newtonsoft.Json;

namespace ED.Journal.Statistics
{
    public class CombatStatistics
    {
        [JsonProperty("Bounties_Claimed")]
        public int BountiesClaimed { get; set; }

        [JsonProperty("Bounty_Hunting_Profit")]
        public int BountyHuntingProfit { get; set; }

        [JsonProperty("Combat_Bonds")]
        public int CombatBonds { get; set; }

        [JsonProperty("Combat_Bond_Profits")]
        public int CombatBondProfits { get; set; }

        [JsonProperty("Assassinations")]
        public int Assassinations { get; set; }

        [JsonProperty("Assassination_Profits")]
        public int AssassinationProfits { get; set; }

        [JsonProperty("Highest_Single_Reward")]
        public int HighestSingleReward { get; set; }

        [JsonProperty("Skimmers_Killed")]
        public int SkimmersKilled { get; set; }
    }
}