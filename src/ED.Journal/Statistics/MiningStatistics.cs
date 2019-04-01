using Newtonsoft.Json;

namespace ED.Journal.Statistics
{
    public class MiningStatistics
    {
        [JsonProperty("Mining_Profits")]
        public int MiningProfits { get; set; }

        [JsonProperty("Quantity_Mined")]
        public int QuantityMined { get; set; }

        [JsonProperty("Materials_Collected")]
        public int MaterialsCollected { get; set; }
    }
}