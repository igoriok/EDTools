using Newtonsoft.Json;

namespace ED.Journal
{
    public class Engineer
    {
        [JsonProperty("Engineer")]
        public string Name { get; set; }

        [JsonProperty("EngineerID")]
        public long EngineerID { get; set; }

        [JsonProperty("Progress")]
        public string Progress { get; set; }

        [JsonProperty("RankProgress", NullValueHandling = NullValueHandling.Ignore)]
        public int? RankProgress { get; set; }

        [JsonProperty("Rank", NullValueHandling = NullValueHandling.Ignore)]
        public int? Rank { get; set; }
    }
}