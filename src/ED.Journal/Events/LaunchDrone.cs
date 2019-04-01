using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class LaunchDrone : JournalEvent
    {
        [JsonProperty("Type")]
        public string Type { get; set; }

        public LaunchDrone()
            : base(nameof(LaunchDrone))
        {
        }
    }
}
