using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class CrewMemberJoins : JournalEvent
    {
        [JsonProperty("Crew")]
        public string Crew { get; set; }

        public CrewMemberJoins()
            : base(nameof(CrewMemberJoins))
        {
        }
    }
}