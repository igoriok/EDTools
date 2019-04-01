using Newtonsoft.Json;

namespace ED.Tools.Inara.Models
{
    public class CommanderCombatKill : StarSystem
    {
        [JsonProperty("opponentName")]
        public string OpponentName { get; }

        [JsonConstructor]
        public CommanderCombatKill(string starSystemName, string opponentName)
            : base(starSystemName)
        {
            OpponentName = opponentName;
        }
    }
}