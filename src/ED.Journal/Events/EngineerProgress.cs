using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class EngineerProgress : JournalEvent
    {
        [JsonProperty("Engineers")]
        public Engineer[] Engineers { get; set; }

        public EngineerProgress()
            : base(nameof(EngineerProgress))
        {
        }
    }
}
