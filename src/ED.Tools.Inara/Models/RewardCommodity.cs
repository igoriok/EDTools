using Newtonsoft.Json;

namespace ED.Tools.Inara.Models
{
    public class RewardCommodity
    {
        [JsonProperty("itemName")]
        public string ItemName { get; }

        [JsonProperty("itemCount")]
        public int ItemCount { get; }

        [JsonConstructor]
        public RewardCommodity(string itemName, int itemCount)
        {
            ItemName = itemName;
            ItemCount = itemCount;
        }
    }
}