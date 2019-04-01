using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class ShipyardNew : JournalEvent
    {
        [JsonProperty("ShipType")]
        public string ShipType { get; set; }

        [JsonProperty("ShipType_Localised")]
        public string ShipTypeLocalised { get; set; }

        [JsonProperty("NewShipID")]
        public long NewShipID { get; set; }

        public ShipyardNew()
            : base(nameof(ShipyardNew))
        {
        }
    }
}
