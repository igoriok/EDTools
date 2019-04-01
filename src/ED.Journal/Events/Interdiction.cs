using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class Interdiction : JournalEvent
    {
        [JsonProperty("Success")]
        public bool Success { get; set; }

        [JsonProperty("Interdicted")]
        public string Interdicted { get; set; }

        [JsonProperty("IsPlayer")]
        public bool IsPlayer { get; set; }

        [JsonProperty("CombatRank")]
        public string CombatRank { get; set; }
        
        [JsonProperty("Faction")]
        public string Faction { get; set; }

        [JsonProperty("Power")]
        public string Power { get; set; }

        public Interdiction()
            : base(nameof(Interdiction))
        {
        }
    }
}
