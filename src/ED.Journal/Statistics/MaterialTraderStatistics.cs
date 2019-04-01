using Newtonsoft.Json;

namespace ED.Journal.Statistics
{
    public class MaterialTraderStatistics
    {
        [JsonProperty("Trades_Completed")]
        public int TradesCompleted { get; set; }
        
        [JsonProperty("Materials_Traded")]
        public int MaterialsTraded { get; set; }

        [JsonProperty("Raw_Materials_Traded")]
        public int? RawMaterialsTraded { get; set; }
        
        [JsonProperty("Encoded_Materials_Traded")]
        public int? EncodedMaterialsTraded { get; set; }
        
        [JsonProperty("Grade_1_Materials_Traded")]
        public int? Grade1MaterialsTraded { get; set; }

        [JsonProperty("Grade_2_Materials_Traded")]
        public int? Grade2MaterialsTraded { get; set; }

        [JsonProperty("Grade_3_Materials_Traded")]
        public int? Grade3MaterialsTraded { get; set; }
        
        [JsonProperty("Grade_4_Materials_Traded")]
        public int? Grade4MaterialsTraded { get; set; }

        [JsonProperty("Grade_5_Materials_Traded")]
        public int? Grade5MaterialsTraded { get; set; }
    }
}