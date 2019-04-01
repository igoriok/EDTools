using Newtonsoft.Json;

namespace ED.Tools.Inara.Models
{
    public class CommanderInventoryCargo
    {
        [JsonProperty("itemName")]
        public string ItemName { get; }

        [JsonProperty("itemCount")]
        public int ItemCount { get; }

        [JsonProperty("isStolen")]
        public bool? IsStolen { get; }

        [JsonProperty("missionGameID")]
        public int? MissionGameID { get; }

        public CommanderInventoryCargo(string itemName, int itemCount, bool? isStolen = null, int? missionGameID = null)
        {
            ItemName = itemName;
            ItemCount = itemCount;
            IsStolen = isStolen;
            MissionGameID = missionGameID;
        }
    }
}