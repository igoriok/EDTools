using Newtonsoft.Json;

namespace ED.Tools.Inara.Models
{
    public class CommanderShip
    {
        [JsonProperty("shipType")]
        public string ShipType { get; }

        [JsonProperty("shipGameID")]
        public int ShipGameID { get; }

        [JsonConstructor]
        public CommanderShip(string shipType, int shipGameID)
        {
            ShipType = shipType;
            ShipGameID = shipGameID;
        }
    }
}