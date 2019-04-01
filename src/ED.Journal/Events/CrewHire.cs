using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class CrewHire : JournalEvent
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("CrewID")]
        public long CrewID { get; set; }

        [JsonProperty("Faction")]
        public string Faction { get; set; }

        [JsonProperty("Cost")]
        public long Cost { get; set; }

        [JsonProperty("CombatRank")]
        public int CombatRank { get; set; }

        public CrewHire()
            : base(nameof(CrewHire))
        {
        }
    }
}
