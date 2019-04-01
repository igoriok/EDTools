using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class ChangeCrewRole : JournalEvent
    {
        [JsonProperty("Role")]
        public string Role { get; set; }

        public ChangeCrewRole()
            : base(nameof(ChangeCrewRole))
        {
        }
    }
}