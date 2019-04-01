using Newtonsoft.Json;

namespace ED.Tools.Inara.Models
{
    public class CommanderShipTransfer : CommanderShip
    {
        [JsonProperty("starsystemName")]
        public string StarSystemName { get; }

        [JsonProperty("stationName")]
        public string StationName { get; }

        [JsonProperty("marketID")]
        public int? MarketID { get; }

        [JsonProperty("transferTime")]
        public int? TransferTime { get; }

        [JsonConstructor]
        public CommanderShipTransfer(string shipType, int shipGameID, string starSystemName, string stationName, int? marketID = null, int? transferTime = null)
            : base(shipType, shipGameID)
        {
            StarSystemName = starSystemName;
            StationName = stationName;
            MarketID = marketID;
            TransferTime = transferTime;
        }
    }
}