using Newtonsoft.Json;

namespace ED.Tools.Inara.Models
{
    public class CommanderCombatInterdictionEscape : StarSystem
    {
        [JsonProperty("opponentName")]
        public string OpponentName { get; }

        [JsonProperty("isPlayer")]
        public bool IsPlayer { get; }

        [JsonConstructor]
        public CommanderCombatInterdictionEscape(string starSystemName, string opponentName, bool isPlayer)
            : base(starSystemName)
        {
            OpponentName = opponentName;
            IsPlayer = isPlayer;
        }
    }
}