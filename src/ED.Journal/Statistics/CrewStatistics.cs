using Newtonsoft.Json;

namespace ED.Journal.Statistics
{
    public class CrewStatistics
    {
        [JsonProperty("NpcCrew_TotalWages")]
        public int NpcCrewTotalWages { get; set; }

        [JsonProperty("NpcCrew_Hired")]
        public int NpcCrewHired { get; set; }

        [JsonProperty("NpcCrew_Fired")]
        public int NpcCrewFired { get; set; }

        [JsonProperty("NpcCrew_Died")]
        public int NpcCrewDied { get; set; }
    }
}