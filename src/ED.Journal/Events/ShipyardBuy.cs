using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class ShipyardBuy : JournalEvent
    {
        [JsonProperty("ShipType")]
        public string ShipType { get; set; }

        [JsonProperty("ShipType_Localised")]
        public string ShipTypeLocalised { get; set; }

        [JsonProperty("ShipPrice")]
        public long ShipPrice { get; set; }

        [JsonProperty("StoreOldShip")]
        public string StoreOldShip { get; set; }

        [JsonProperty("StoreShipID")]
        public long StoreShipID { get; set; }

        [JsonProperty("MarketID")]
        public long MarketID { get; set; }

        public ShipyardBuy()
            : base(nameof(ShipyardBuy))
        {
        }
    }
}
