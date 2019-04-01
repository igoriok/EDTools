using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class StartJump : JournalEvent
    {
        [JsonProperty("JumpType")]
        public string JumpType { get; set; }

        [JsonProperty("StarSystem")]
        public string StarSystem { get; set; }

        [JsonProperty("StarClass")]
        public string StarClass { get; set; }

        [JsonProperty("SystemAddress")]
        public long? SystemAddress { get; set; }

        public StartJump()
            : base(nameof(StartJump))
        {
        }
    }
}
