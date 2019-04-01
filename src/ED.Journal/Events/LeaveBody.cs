using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class LeaveBody : JournalEvent
    {
        [JsonProperty("StarSystem")]
        public string StarSystem { get; set; }

        [JsonProperty("SystemAddress")]
        public long SystemAddress { get; set; }

        [JsonProperty("Body")]
        public string Body { get; set; }

        [JsonProperty("BodyID")]
        public long BodyID { get; set; }

        public LeaveBody()
            : base(nameof(LeaveBody))
        {
        }
    }
}
