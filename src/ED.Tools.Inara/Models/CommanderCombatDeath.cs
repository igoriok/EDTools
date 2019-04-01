using Newtonsoft.Json;

namespace ED.Tools.Inara.Models
{
    public class CommanderCombatDeath : StarSystem
    {
        [JsonProperty("opponentName")]
        public string OpponentName { get; }

        [JsonProperty("wingOpponentNames")]
        public string[] WingOpponentNames { get; }

        [JsonProperty("isPlayer")]
        public bool? IsPlayer { get; }

        [JsonConstructor]
        public CommanderCombatDeath(string starSystemName, string opponentName = null, string[] wingOpponentNames = null, bool? isPlayer = null)
            : base(starSystemName)
        {
            OpponentName = opponentName;
            WingOpponentNames = wingOpponentNames;
            IsPlayer = isPlayer;
        }
    }
}