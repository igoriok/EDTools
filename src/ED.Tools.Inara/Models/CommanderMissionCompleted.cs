using Newtonsoft.Json;

namespace ED.Tools.Inara.Models
{
    public class CommanderMissionCompleted
    {
        [JsonProperty("missionGameID")]
        public string MissionGameID { get; }

        [JsonProperty("donationCredits")]
        public int? DonationCredits { get; }

        [JsonProperty("rewardCredits")]
        public int? RewardCredits { get; }

        [JsonProperty("rewardPermits")]
        public RewardPermit[] RewardPermits { get; }

        [JsonProperty("rewardCommodities")]
        public RewardCommodity[] RewardCommodities { get; }

        [JsonProperty("rewardMaterials")]
        public RewardMaterial[] RewardMaterials { get; }

        [JsonProperty("minorfactionEffects")]
        public MinorFactionEffect[] MinorFactionEffects { get; }

        [JsonConstructor]
        public CommanderMissionCompleted(
            string missionGameID, int? donationCredits = null, int? rewardCredits = null,
            RewardPermit[] rewardPermits = null, RewardCommodity[] rewardCommodities = null,
            RewardMaterial[] rewardMaterials = null, MinorFactionEffect[] minorFactionEffects = null)
        {
            MissionGameID = missionGameID;
            DonationCredits = donationCredits;
            RewardCredits = rewardCredits;
            RewardPermits = rewardPermits;
            RewardCommodities = rewardCommodities;
            RewardMaterials = rewardMaterials;
            MinorFactionEffects = minorFactionEffects;
        }
    }
}