using Newtonsoft.Json;
using System;

namespace ED.Tools.Inara.Models
{
    public class CommanderMission
    {
        [JsonProperty("missionName")]
        public string MissionName { get; }

        [JsonProperty("missionGameID")]
        public string MissionGameID { get; }

        [JsonProperty("starsystemNameOrigin")]
        public string StarSystemNameOrigin { get; }

        [JsonProperty("missionExpiry")]
        public DateTime? MissionExpiry { get; }

        [JsonProperty("influenceGain")]
        public string InfluenceGain { get; }

        [JsonProperty("reputationGain")]
        public string ReputationGain { get; }

        [JsonProperty("stationNameOrigin")]
        public string StationNameOrigin { get; }

        [JsonProperty("minorfactionNameOrigin")]
        public string MinorFactionNameOrigin { get; }

        [JsonProperty("starsystemNameTarget")]
        public string StarSystemNameTarget { get; }

        [JsonProperty("stationNameTarget")]
        public string StationNameTarget { get; }

        [JsonProperty("minorfactionNameTarget")]
        public string MinorFactionNameTarget { get; }

        [JsonProperty("commodityName")]
        public string CommodityName { get; }

        [JsonProperty("commodityCount")]
        public int? CommodityCount { get; }

        [JsonProperty("targetName")]
        public string TargetName { get; }

        [JsonProperty("targetType")]
        public string TargetType { get; }

        [JsonProperty("killCount")]
        public int? KillCount { get; }

        [JsonProperty("passengerType")]
        public string PassengerType { get; }

        [JsonProperty("passengerCount")]
        public int? PassengerCount { get; }

        [JsonProperty("passengerIsVIP")]
        public bool? PassengerIsVIP { get; }

        [JsonProperty("passengerIsWanted")]
        public bool? PassengerIsWanted { get; }

        [JsonConstructor]
        public CommanderMission(
            string missionName, string missionGameID, string starSystemNameOrigin, DateTime? missionExpiry = null,
            string influenceGain = null, string reputationGain = null, string stationNameOrigin = null, string minorFactionNameOrigin = null,
            string starSystemNameTarget = null, string stationNameTarget = null, string minorFactionNameTarget = null,
            string commodityName = null, int? commodityCount = null, string targetName = null, string targetType = null, int? killCount = null,
            string passengerType = null, int? passengerCount = null, bool? passengerIsVIP = null, bool? passengerIsWanted = null)
        {
            MissionName = missionName;
            MissionGameID = missionGameID;
            StarSystemNameOrigin = starSystemNameOrigin;
            MissionExpiry = missionExpiry;
            InfluenceGain = influenceGain;
            ReputationGain = reputationGain;
            StationNameOrigin = stationNameOrigin;
            MinorFactionNameOrigin = minorFactionNameOrigin;
            StarSystemNameTarget = starSystemNameTarget;
            StationNameTarget = stationNameTarget;
            MinorFactionNameTarget = minorFactionNameTarget;
            CommodityName = commodityName;
            CommodityCount = commodityCount;
            TargetName = targetName;
            TargetType = targetType;
            KillCount = killCount;
            PassengerType = passengerType;
            PassengerCount = passengerCount;
            PassengerIsVIP = passengerIsVIP;
            PassengerIsWanted = passengerIsWanted;
        }
    }
}