using Newtonsoft.Json;

namespace ED.Journal.Statistics
{
    public class ExplorationStatistics
    {
        [JsonProperty("Systems_Visited")]
        public int SystemsVisited { get; set; }

        [JsonProperty("Fuel_Scooped")]
        public double FuelScooped { get; set; }

        [JsonProperty("Fuel_Purchased")]
        public double FuelPurchased { get; set; }

        [JsonProperty("Exploration_Profits")]
        public int ExplorationProfits { get; set; }

        [JsonProperty("Planets_Scanned_To_Level_2")]
        public int PlanetsScannedToLevel2 { get; set; }

        [JsonProperty("Planets_Scanned_To_Level_3")]
        public int PlanetsScannedToLevel3 { get; set; }

        [JsonProperty("Efficient_Scans")]
        public int EfficientScans { get; set; }
        
        [JsonProperty("Highest_Payout")]
        public int HighestPayout { get; set; }

        [JsonProperty("Total_Hyperspace_Distance")]
        public int TotalHyperspaceDistance { get; set; }

        [JsonProperty("Total_Hyperspace_Jumps")]
        public int TotalHyperspaceJumps { get; set; }

        [JsonProperty("Greatest_Distance_From_Start")]
        public double GreatestDistanceFromStart { get; set; }

        [JsonProperty("Time_Played")]
        public int TimePlayed { get; set; }
    }
}