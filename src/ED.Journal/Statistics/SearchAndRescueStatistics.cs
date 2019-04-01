using Newtonsoft.Json;

namespace ED.Journal.Statistics
{
    public class SearchAndRescueStatistics
    {
        [JsonProperty("SearchRescue_Traded")]
        public int SearchRescueTraded { get; set; }

        [JsonProperty("SearchRescue_Profit")]
        public int SearchRescueProfit { get; set; }

        [JsonProperty("SearchRescue_Count")]
        public int SearchRescueCount { get; set; }
    }
}