using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class VehicleSwitch : JournalEvent
    {
        [JsonProperty("To")]
        public string To { get; set; }

        public VehicleSwitch()
            : base(nameof(VehicleSwitch))
        {
        }
    }
}
