using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class LaunchFighter : JournalEvent
    {
        [JsonProperty("Loadout")]
        public string Loadout { get; set; }

        [JsonProperty("PlayerControlled")]
        public bool PlayerControlled { get; set; }

        public LaunchFighter()
            : base(nameof(LaunchFighter))
        {
        }
    }
}
