using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class SetUserShipName : JournalEvent
    {
        [JsonProperty("Ship")]
        public string Ship { get; set; }

        [JsonProperty("ShipID")]
        public long ShipID { get; set; }

        [JsonProperty("UserShipName")]
        public string UserShipName { get; set; }

        [JsonProperty("UserShipId")]
        public string UserShipId { get; set; }

        public SetUserShipName()
            : base(nameof(SetUserShipName))
        {
        }
    }
}
