using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class NavBeaconScan : JournalEvent
    {
        [JsonProperty("SystemAddress")]
        public long SystemAddress { get; set; }

        [JsonProperty("NumBodies")]
        public int NumBodies { get; set; }

        public NavBeaconScan()
            : base(nameof(NavBeaconScan))
        {
        }
    }
}