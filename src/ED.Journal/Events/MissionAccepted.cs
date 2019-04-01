using System;
using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class MissionAccepted : JournalEvent
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("LocalisedName")]
        public string LocalisedName { get; set; }

        [JsonProperty("Faction")]
        public string Faction { get; set; }

        [JsonProperty("Commodity")]
        public string Commodity { get; set; }

        [JsonProperty("Commodity_Localised")]
        public string CommodityLocalised { get; set; }

        [JsonProperty("Count")]
        public long Count { get; set; }

        [JsonProperty("DestinationSystem")]
        public string DestinationSystem { get; set; }

        [JsonProperty("Expiry")]
        public DateTime Expiry { get; set; }

        [JsonProperty("Influence")]
        public string Influence { get; set; }

        [JsonProperty("Reputation")]
        public string Reputation { get; set; }

        [JsonProperty("Reward")]
        public long Reward { get; set; }

        [JsonProperty("PassengerCount")]
        public long PassengerCount { get; set; }

        [JsonProperty("PassengerVIPs")]
        public bool PassengerViPs { get; set; }

        [JsonProperty("PassengerWanted")]
        public bool PassengerWanted { get; set; }

        [JsonProperty("PassengerType")]
        public string PassengerType { get; set; }

        [JsonProperty("MissionID")]
        public long MissionID { get; set; }

        public MissionAccepted()
            : base(nameof(MissionAccepted))
        {
        }
    }
}
