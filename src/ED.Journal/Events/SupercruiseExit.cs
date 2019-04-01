using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class SupercruiseExit : JournalEvent
    {
        [JsonProperty("StarSystem")]
        public string StarSystem { get; set; }

        [JsonProperty("SystemAddress")]
        public long SystemAddress { get; set; }

        [JsonProperty("Body")]
        public string Body { get; set; }

        [JsonProperty("BodyID")]
        public long BodyID { get; set; }

        [JsonProperty("BodyType")]
        public string BodyType { get; set; }

        public SupercruiseExit()
            : base(nameof(SupercruiseExit))
        {
        }
    }
}
