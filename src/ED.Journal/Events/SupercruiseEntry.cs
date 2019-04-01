using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class SupercruiseEntry : JournalEvent
    {
        [JsonProperty("StarSystem")]
        public string StarSystem { get; set; }

        [JsonProperty("SystemAddress")]
        public long SystemAddress { get; set; }

        public SupercruiseEntry()
            : base(nameof(SupercruiseEntry))
        {
        }
    }
}