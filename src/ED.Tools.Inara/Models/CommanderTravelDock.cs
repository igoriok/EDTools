using Newtonsoft.Json;

namespace ED.Tools.Inara.Models
{
    public class CommanderTravelDock : StarSystem
    {
        [JsonProperty("stationName")]
        public string StationName { get; }

        [JsonProperty("marketID")]
        public int? MarketID { get; }

        [JsonProperty("shipType")]
        public string ShipType { get; }

        [JsonProperty("shipGameID")]
        public int? ShipGameID { get; }

        [JsonConstructor]
        public CommanderTravelDock(string starSystemName, string stationName, int? marketID = null, string shipType = null, int? shipGameID = null)
            : base(starSystemName)
        {
            StationName = stationName;
            MarketID = marketID;
            ShipType = shipType;
            ShipGameID = shipGameID;
        }
    }
}