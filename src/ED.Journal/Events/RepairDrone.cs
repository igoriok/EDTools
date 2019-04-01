using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class RepairDrone : JournalEvent
    {
        [JsonProperty("HullRepaired")]
        public double HullRepaired { get; set; }

        [JsonProperty("CockpitRepaired")]
        public double CockpitRepaired { get; set; }

        public RepairDrone()
            : base(nameof(RepairDrone))
        {
        }
    }
}
