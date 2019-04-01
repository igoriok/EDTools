using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class ShipTargetted : JournalEvent
    {
        [JsonProperty("TargetLocked")]
        public bool TargetLocked { get; set; }

        [JsonProperty("Ship")]
        public string Ship { get; set; }

        [JsonProperty("ScanStage")]
        public int ScanStage { get; set; }

        [JsonProperty("PilotName")]
        public string PilotName { get; set; }

        [JsonProperty("PilotRank")]
        public string PilotRank { get; set; }

        [JsonProperty("ShieldHealth")]
        public float? ShieldHealth { get; set; }

        [JsonProperty("HullHealth")]
        public float? HullHealth { get; set; }

        [JsonProperty("Faction")]
        public string Faction { get; set; }

        [JsonProperty("LegalStatus")]
        public string LegalStatus { get; set; }

        [JsonProperty("Bounty")]
        public string Bounty { get; set; }

        [JsonProperty("SubSystem")]
        public string SubSystem { get; set; }

        [JsonProperty("SubSystemHealth")]
        public float? SubSystemHealth { get; set; }

        public ShipTargetted()
            : base(nameof(ShipTargetted))
        {
        }
    }
}