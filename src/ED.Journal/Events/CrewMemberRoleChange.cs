using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class CrewMemberRoleChange : JournalEvent
    {
        [JsonProperty("Crew")]
        public string Crew { get; set; }

        [JsonProperty("Role")]
        public string Role { get; set; }

        public CrewMemberRoleChange()
            : base(nameof(CrewMemberRoleChange))
        {
        }
    }
}