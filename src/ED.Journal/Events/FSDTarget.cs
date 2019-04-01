using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class FSDTarget : JournalEvent
    {
        [JsonProperty("SystemAddress")]
        public long SystemAddress { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        public FSDTarget()
            : base(nameof(FSDTarget))
        {
        }
    }
}