using Newtonsoft.Json;

namespace ED.Tools.Inara.Models
{
    public class CommanderTravelFSDJump : StarSystem
    {
        [JsonProperty("jumpDistance")]
        public float? JumpDistance { get; }

        [JsonProperty("shipType")]
        public string ShipType { get; }

        [JsonProperty("shipGameID")]
        public int? ShipGameID { get; }

        [JsonConstructor]
        public CommanderTravelFSDJump(string starSystemName, float? jumpDistance = null, string shipType = null, int? shipGameID = null)
            : base(starSystemName)
        {
            JumpDistance = jumpDistance;
            ShipType = shipType;
            ShipGameID = shipGameID;
        }
    }
}