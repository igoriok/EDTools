using Newtonsoft.Json;

namespace ED.Tools.Inara.Models
{
    public class RewardMaterial
    {
        [JsonProperty("itemName")]
        public string ItemName { get; }

        [JsonProperty("itemCount")]
        public int ItemCount { get; }

        [JsonConstructor]
        public RewardMaterial(string itemName, int itemCount)
        {
            ItemName = itemName;
            ItemCount = itemCount;
        }
    }
}