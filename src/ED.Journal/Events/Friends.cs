using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class Friends : JournalEvent
    {
        [JsonProperty("Status")]
        public string Status { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        public Friends()
            : base(nameof(Friends))
        {
        }
    }
}
