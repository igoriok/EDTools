using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class Scanned : JournalEvent
    {
        [JsonProperty("ScanType")]
        public string ScanType { get; set; }

        public Scanned()
            : base(nameof(Scanned))

        {
        }
    }
}