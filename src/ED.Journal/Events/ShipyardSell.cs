using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class ShipyardSell : JournalEvent
    {
        [JsonProperty("ShipType")]
        public string ShipType { get; set; }

        [JsonProperty("ShipType_Localised")]
        public string ShipTypeLocalised { get; set; }

        [JsonProperty("SellShipID")]
        public long SellShipID { get; set; }

        [JsonProperty("ShipPrice")]
        public long ShipPrice { get; set; }

        [JsonProperty("MarketID")]
        public long MarketID { get; set; }

        public ShipyardSell()
            : base(nameof(ShipyardSell))
        {
        }
    }
}
