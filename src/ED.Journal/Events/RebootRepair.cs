using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class RebootRepair : JournalEvent
    {
        [JsonProperty("Modules")]
        public string[] Modules { get; set; }

        public RebootRepair()
            : base(nameof(RebootRepair))
        {
        }
    }
}
