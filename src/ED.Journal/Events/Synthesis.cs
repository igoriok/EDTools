using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class Synthesis : JournalEvent
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Materials")]
        public Material[] Materials { get; set; }

        public Synthesis()
            : base(nameof(Synthesis))
        {
        }
    }
}
