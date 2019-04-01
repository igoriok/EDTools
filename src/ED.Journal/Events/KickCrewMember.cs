using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class KickCrewMember : JournalEvent
    {
        [JsonProperty("Crew")]
        public string Crew { get; set; }

        [JsonProperty("OnCrime")]
        public bool OnCrime { get; set; }

        public KickCrewMember()
            : base(nameof(KickCrewMember))
        {
        }
    }
}
