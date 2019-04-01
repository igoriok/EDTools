using Newtonsoft.Json;

namespace ED.Tools.Inara.Models
{
    public class CommanderInventoryMaterialsItem
    {
        [JsonProperty("itemName")]
        public string ItemName { get; }

        [JsonProperty("itemCount")]
        public int ItemCount { get; }

        [JsonConstructor]
        public CommanderInventoryMaterialsItem(string itemName, int itemCount)
        {
            ItemName = itemName;
            ItemCount = itemCount;
        }
    }
}