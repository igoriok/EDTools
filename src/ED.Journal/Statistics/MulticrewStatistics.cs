using Newtonsoft.Json;

namespace ED.Journal.Statistics
{
    public class MulticrewStatistics
    {
        [JsonProperty("Multicrew_Time_Total")]
        public int MulticrewTimeTotal { get; set; }

        [JsonProperty("Multicrew_Gunner_Time_Total")]
        public int MulticrewGunnerTimeTotal { get; set; }

        [JsonProperty("Multicrew_Fighter_Time_Total")]
        public int MulticrewFighterTimeTotal { get; set; }

        [JsonProperty("Multicrew_Credits_Total")]
        public int MulticrewCreditsTotal { get; set; }

        [JsonProperty("Multicrew_Fines_Total")]
        public int MulticrewFinesTotal { get; set; }
    }
}