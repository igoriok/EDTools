using Newtonsoft.Json;

namespace ED.Tools.Inara.Models
{
    public class CommanderShipDetails : CommanderShip
    {
        [JsonProperty("shipName")]
        public string ShipName { get; }

        [JsonProperty("shipIdent")]
        public string ShipIdent { get; }

        [JsonProperty("isCurrentShip")]
        public bool? IsCurrentShip { get; }

        [JsonProperty("isMainShip")]
        public bool? IsMainShip { get; }

        [JsonProperty("isHot")]
        public bool? IsHot { get; }

        [JsonProperty("shipHullValue")]
        public int? ShipHullValue { get; }

        [JsonProperty("shipModulesValue")]
        public int? ShipModulesValue { get; }

        [JsonProperty("shipRebuyCost")]
        public int? ShipReBuyCost { get; }

        [JsonProperty("starsystemName")]
        public string StarSystemName { get; }

        [JsonProperty("stationName")]
        public string StationName { get; }

        [JsonProperty("marketID")]
        public int? MarketID { get; }

        [JsonConstructor]
        public CommanderShipDetails(
            string shipType, int shipGameID, string shipName = null, string shipIdent = null,
            bool? isCurrentShip = null, bool? isMainShip = null, bool? isHot = null,
            int? shipHullValue = null, int? shipModulesValue = null, int? shipReBuyCost = null,
            string starSystemName = null, string stationName = null, int? marketID = null)
            : base(shipType, shipGameID)
        {
            ShipName = shipName;
            ShipIdent = shipIdent;
            IsCurrentShip = isCurrentShip;
            IsMainShip = isMainShip;
            IsHot = isHot;
            ShipHullValue = shipHullValue;
            ShipModulesValue = shipModulesValue;
            ShipReBuyCost = shipReBuyCost;
            StarSystemName = starSystemName;
            StationName = stationName;
            MarketID = marketID;
        }
    }
}