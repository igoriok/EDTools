using Newtonsoft.Json;

namespace ED.Tools.Inara.Models
{
    public class CommanderStorageModule
    {
        [JsonProperty("itemName")]
        public string ItemName { get; }

        [JsonProperty("itemValue")]
        public int? ItemValue { get; }

        [JsonProperty("isHot")]
        public bool? IsHot { get; }

        [JsonProperty("starsystemName")]
        public string StarSystemName { get; }

        [JsonProperty("stationName")]
        public string StationName { get; }

        [JsonProperty("marketID")]
        public int? MarketID { get; }

        [JsonConstructor]
        public CommanderStorageModule(string itemName, int? itemValue = null, bool? isHot = null, string starSystemName = null, string stationName = null, int? marketID = null)
        {
            ItemName = itemName;
            ItemValue = itemValue;
            IsHot = isHot;
            StarSystemName = starSystemName;
            StationName = stationName;
            MarketID = marketID;
        }
    }
}