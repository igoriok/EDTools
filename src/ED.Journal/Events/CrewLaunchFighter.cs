using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class CrewLaunchFighter : JournalEvent
    {
        [JsonProperty("Crew")]
        public string Crew { get; set; }

        public CrewLaunchFighter()
            : base(nameof(CrewLaunchFighter))
        {
        }
    }
}
