using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class MissionCompleted : JournalEvent
    {
        [JsonProperty("Faction")]
        public string Faction { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("MissionID")]
        public long MissionID { get; set; }

        [JsonProperty("Target")]
        public string Target { get; set; }
        
        [JsonProperty("TargetType")]
        public string TargetType { get; set; }

        [JsonProperty("TargetType_Localised")]
        public string TargetTypeLocalised { get; set; }

        [JsonProperty("TargetFaction")]
        public string TargetFaction { get; set; }

        [JsonProperty("NewDestinationSystem")]
        public string NewDestinationSystem { get; set; }

        [JsonProperty("DestinationSystem")]
        public string DestinationSystem { get; set; }

        [JsonProperty("NewDestinationStation")]
        public string NewDestinationStation { get; set; }

        [JsonProperty("DestinationStation")]
        public string DestinationStation { get; set; }

        [JsonProperty("Reward")]
        public long Reward { get; set; }

        [JsonProperty("MaterialsReward")]
        public MaterialsReward[] MaterialsReward { get; set; }

        [JsonProperty("FactionEffects")]
        public FactionEffect[] FactionEffects { get; set; }

        public MissionCompleted()
            : base(nameof(MissionCompleted))
        {
        }
    }
}
