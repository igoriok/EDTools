using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class CrimeVictim : JournalEvent
    {
        [JsonProperty("Offender")]
        public string Offender { get; set; }

        [JsonProperty("CrimeType")]
        public string CrimeType { get; set; }

        [JsonProperty("Bounty")]
        public long Bounty { get; set; }

        public CrimeVictim()
            : base(nameof(CrimeVictim))
        {
        }
    }
}