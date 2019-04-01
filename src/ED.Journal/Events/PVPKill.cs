using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class PVPKill : JournalEvent
    {
        [JsonProperty("Victim")]
        public string Victim { get; set; }

        [JsonProperty("CombatRank")]
        public int CombatRank { get; set; }

        public PVPKill()
            : base(nameof(PVPKill))
        {
        }
    }
}
