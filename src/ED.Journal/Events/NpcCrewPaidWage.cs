using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class NpcCrewPaidWage : JournalEvent
    {
        [JsonProperty("NpcCrewName")]
        public string NpcCrewName { get; set; }

        [JsonProperty("NpcCrewId")]
        public long NpcCrewId { get; set; }

        [JsonProperty("Amount")]
        public long Amount { get; set; }

        public NpcCrewPaidWage()
            : base(nameof(NpcCrewPaidWage))
        {
        }
    }
}
