using System;
using ED.Journal.Converters;
using Newtonsoft.Json;

namespace ED.Journal
{
    public class ShipsRemote : ShipsHere
    {
        [JsonProperty("StarSystem")]
        public string StarSystem { get; set; }

        [JsonProperty("ShipMarketID")]
        public long ShipMarketID { get; set; }

        [JsonProperty("TransferPrice")]
        public long TransferPrice { get; set; }

        [JsonProperty("TransferTime")]
        [JsonConverter(typeof(TimeSpanSecondsConverter))]
        public TimeSpan TransferTime { get; set; }
    }
}