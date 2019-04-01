using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class CrewFire : JournalEvent
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("CrewID")]
        public long CrewID { get; set; }

        public CrewFire()
            : base(nameof(CrewFire))
        {
        }
    }
}