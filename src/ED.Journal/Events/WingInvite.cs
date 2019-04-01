using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class WingInvite : JournalEvent
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        public WingInvite()
            : base(nameof(WingInvite))
        {
        }
    }
}
