using Newtonsoft.Json;

namespace ED.Tools.Inara.Models.Statistics
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