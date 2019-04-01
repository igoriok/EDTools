using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class WingAdd : JournalEvent
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        public WingAdd()
            : base(nameof(WingAdd))
        {
        }
    }
}
