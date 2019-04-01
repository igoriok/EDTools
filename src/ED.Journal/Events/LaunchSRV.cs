using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class LaunchSRV : JournalEvent
    {
        [JsonProperty("Loadout")]
        public string Loadout { get; set; }

        [JsonProperty("PlayerControlled")]
        public bool PlayerControlled { get; set; }

        public LaunchSRV()
            : base(nameof(LaunchSRV))
        {
        }
    }
}
