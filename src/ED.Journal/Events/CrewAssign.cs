using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class CrewAssign : JournalEvent
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("CrewID")]
        public long CrewID { get; set; }

        [JsonProperty("Role")]
        public string Role { get; set; }

        public CrewAssign()
            : base(nameof(CrewAssign))
        {
        }
    }
}