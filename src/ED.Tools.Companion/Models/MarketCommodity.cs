using Newtonsoft.Json;

namespace ED.Tools.Companion.Models
{
    public class MarketCommodity
    {
        [JsonProperty("id")]
        public long Id { get; set; }
        
        [JsonProperty("name")]
        public string Name { get; set; }
        
        [JsonProperty("legality")]
        public string Legality { get; set; }
        
        [JsonProperty("buyPrice")]
        public long BuyPrice { get; set; }
        
        [JsonProperty("sellPrice")]
        public long SellPrice { get; set; }
        
        [JsonProperty("meanPrice")]
        public long MeanPrice { get; set; }
        
        [JsonProperty("demandBracket")]
        public long DemandBracket { get; set; }
        
        [JsonProperty("stockBracket")]
        public long StockBracket { get; set; }
        
        [JsonProperty("stock")]
        public long Stock { get; set; }
        
        [JsonProperty("demand")]
        public long Demand { get; set; }
        
        [JsonProperty("statusFlags")]
        public string[] StatusFlags { get; set; }
        
        [JsonProperty("categoryname")]
        public string CategoryName { get; set; }
        
        [JsonProperty("locName")]
        public string LocName { get; set; }
    }
}