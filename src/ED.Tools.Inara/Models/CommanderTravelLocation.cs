using Newtonsoft.Json;

namespace ED.Tools.Inara.Models
{
    public class CommanderTravelLocation : StarSystem
    {
        [JsonProperty("stationName")]
        public string StationName { get; }

        [JsonProperty("marketID")]
        public int? MarketID { get; }

        [JsonConstructor]
        public CommanderTravelLocation(string starSystemName, string stationName = null, int? marketID = null)
            : base(starSystemName)
        {
            StationName = stationName;
            MarketID = marketID;
        }
    }
}