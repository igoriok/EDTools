using System.Collections.Generic;
using Newtonsoft.Json;

namespace ED.Tools.Companion.Models
{
    public class Market
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("outpostType")]
        public string OutpostType { get; set; }

        [JsonProperty("imported")]
        public Dictionary<long, string> Imported { get; set; }

        [JsonProperty("exported")]
        public Dictionary<long, string> Exported { get; set; }

        [JsonProperty("services")]
        public Dictionary<long, string> Services { get; set; }

        [JsonProperty("economies")]
        public Dictionary<long, MarketEconomy> Economies { get; set; }

        [JsonProperty("prohibited")]
        public Dictionary<long, string> Prohibited { get; set; }

        [JsonProperty("commodities")]
        public MarketCommodity[] Commodities { get; set; }
    }
}