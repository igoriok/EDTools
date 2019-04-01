using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class ShipTargeted : JournalEvent
    {
        [JsonProperty("TargetLocked")]
        public bool TargetLocked { get; set; }

        [JsonProperty("Ship")]
        public string Ship { get; set; }

        [JsonProperty("Ship_Localised")]
        public string ShipLocalised { get; set; }

        [JsonProperty("ScanStage")]
        public long ScanStage { get; set; }

        [JsonProperty("PilotName")]
        public string PilotName { get; set; }

        [JsonProperty("PilotName_Localised")]
        public string PilotNameLocalised { get; set; }

        [JsonProperty("PilotRank")]
        public string PilotRank { get; set; }

        [JsonProperty("ShieldHealth")]
        public double ShieldHealth { get; set; }

        [JsonProperty("HullHealth")]
        public double HullHealth { get; set; }

        [JsonProperty("Faction")]
        public string Faction { get; set; }

        [JsonProperty("LegalStatus")]
        public string LegalStatus { get; set; }

        [JsonProperty("Bounty")]
        public long Bounty { get; set; }

        [JsonProperty("Subsystem")]
        public string Subsystem { get; set; }

        [JsonProperty("Subsystem_Localised")]
        public string SubsystemLocalised { get; set; }

        [JsonProperty("SubsystemHealth")]
        public double SubsystemHealth { get; set; }

        public ShipTargeted()
            : base(nameof(ShipTargeted))
        {
        }
    }
}
