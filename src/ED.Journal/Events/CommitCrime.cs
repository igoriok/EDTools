using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class CommitCrime : JournalEvent
    {
        [JsonProperty("CrimeType")]
        public string CrimeType { get; set; }

        [JsonProperty("Faction")]
        public string Faction { get; set; }

        [JsonProperty("Victim")]
        public string Victim { get; set; }

        [JsonProperty("Victim_Localised")]
        public string VictimLocalised { get; set; }

        [JsonProperty("Bounty")]
        public long Bounty { get; set; }

        public CommitCrime()
            : base(nameof(CommitCrime))
        {
        }
    }
}