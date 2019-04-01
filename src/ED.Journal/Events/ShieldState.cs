using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class ShieldState : JournalEvent
    {
        [JsonProperty("ShieldsUp")]
        public bool ShieldsUp { get; set; }

        public ShieldState()
            : base(nameof(ShieldState))
        {
        }
    }
}
