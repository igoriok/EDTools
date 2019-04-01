using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class JoinACrew : JournalEvent
    {
        [JsonProperty("Captain")]
        public string Captain { get; set; }

        public JoinACrew()
            : base(nameof(JoinACrew))
        {
        }
    }
}