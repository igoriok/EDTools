using Newtonsoft.Json;

namespace ED.Journal.Statistics
{
    public class SmugglingStatistics
    {
        [JsonProperty("Black_Markets_Traded_With")]
        public int BlackMarketsTradedWith { get; set; }

        [JsonProperty("Black_Markets_Profits")]
        public int BlackMarketsProfits { get; set; }

        [JsonProperty("Resources_Smuggled")]
        public int ResourcesSmuggled { get; set; }

        [JsonProperty("Average_Profit")]
        public int AverageProfit { get; set; }

        [JsonProperty("Highest_Single_Transaction")]
        public int HighestSingleTransaction { get; set; }
    }
}