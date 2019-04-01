using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class AsteroidCracked : JournalEvent
    {
        [JsonProperty("Body")]
        public string Body { get; set; }

        public AsteroidCracked()
            : base(nameof(AsteroidCracked))
        {
        }
    }
}