using Newtonsoft.Json;

namespace ED.Tools.Inara.Models
{
    public class CommanderMissionAbandoned
    {
        [JsonProperty("missionGameID")]
        public string MissionGameID { get; }

        [JsonConstructor]
        public CommanderMissionAbandoned(string missionGameID)
        {
            MissionGameID = missionGameID;
        }
    }
}