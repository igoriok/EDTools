using Newtonsoft.Json;

namespace ED.Tools.Inara.Models
{
    public class CommanderCombatInterdicted : StarSystem
    {
        [JsonProperty("opponentName")]
        public string OpponentName { get; }

        [JsonProperty("isPlayer")]
        public bool IsPlayer { get; }

        [JsonProperty("isSubmit")]
        public bool? IsSubmit { get; }

        public CommanderCombatInterdicted(string starSystemName, string opponentName, bool isPlayer, bool? isSubmit = null)
            : base(starSystemName)
        {
            OpponentName = opponentName;
            IsPlayer = isPlayer;
            IsSubmit = isSubmit;
        }
    }
}