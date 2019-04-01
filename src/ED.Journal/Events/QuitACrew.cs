using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class QuitACrew : JournalEvent
    {
        [JsonProperty("Captain")]
        public string Captain { get; set; }

        public QuitACrew()
            : base(nameof(QuitACrew))
        {
        }
    }
}
