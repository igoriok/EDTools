using Newtonsoft.Json;

namespace ED.Tools.Inara.Models.Statistics
{
    public class CrimeStatistics
    {
        [JsonProperty("Notoriety")]
        public int Notoriety { get; set; }

        [JsonProperty("Fines")]
        public int Fines { get; set; }

        [JsonProperty("Total_Fines")]
        public int TotalFines { get; set; }

        [JsonProperty("Bounties_Received")]
        public int BountiesReceived { get; set; }

        [JsonProperty("Total_Bounties")]
        public int TotalBounties { get; set; }

        [JsonProperty("Highest_Bounty")]
        public int HighestBounty { get; set; }
    }
}