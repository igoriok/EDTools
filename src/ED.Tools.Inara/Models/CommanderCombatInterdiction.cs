using Newtonsoft.Json;

namespace ED.Tools.Inara.Models
{
    public class CommanderCombatInterdiction : StarSystem
    {
        [JsonProperty("opponentName")]
        public string OpponentName { get; }

        [JsonProperty("isPlayer")]
        public bool IsPlayer { get; }

        [JsonProperty("isSuccess")]
        public bool? IsSuccess { get; }

        [JsonConstructor]
        public CommanderCombatInterdiction(string starSystemName, string opponentName, bool isPlayer, bool? isSuccess = null)
            : base(starSystemName)
        {
            OpponentName = opponentName;
            IsPlayer = isPlayer;
            IsSuccess = isSuccess;
        }
    }
}