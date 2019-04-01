using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class Promotion : JournalEvent
    {
        [JsonProperty("Federation")]
        public long Federation { get; set; }

        public Promotion()
            : base(nameof(Promotion))
        {
        }
    }
}
