using Newtonsoft.Json;

namespace ED.Tools.Inara.Models
{
    public class CommanderShipLoadout : CommanderShip
    {
        [JsonProperty("shipLoadout")]
        public ShipLoadout[] ShipLoadout { get; }

        [JsonConstructor]
        public CommanderShipLoadout(string shipType, int shipGameID, ShipLoadout[] shipLoadout)
            : base(shipType, shipGameID)
        {
            ShipLoadout = shipLoadout;
        }
    }
}