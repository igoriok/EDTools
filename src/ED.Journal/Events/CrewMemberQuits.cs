using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class CrewMemberQuits : JournalEvent
    {
        [JsonProperty("Crew")]
        public string Crew { get; set; }

        public CrewMemberQuits()
            : base(nameof(CrewMemberQuits))
        {
        }
    }
}