using Newtonsoft.Json;

namespace ED.Tools.Inara.Models.Statistics
{
    public class TradingStatistics
    {
        [JsonProperty("Markets_Traded_With")]
        public int MarketsTradedWith { get; set; }

        [JsonProperty("Market_Profits")]
        public int MarketProfits { get; set; }

        [JsonProperty("Resources_Traded")]
        public int ResourcesTraded { get; set; }

        [JsonProperty("Average_Profit")]
        public int AverageProfit { get; set; }

        [JsonProperty("Highest_Single_Transaction")]
        public int HighestSingleTransaction { get; set; }
    }
}