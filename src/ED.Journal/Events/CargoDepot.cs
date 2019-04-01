using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class CargoDepot : JournalEvent
    {
        [JsonProperty("MissionID")]
        public long MissionID { get; set; }

        [JsonProperty("UpdateType")]
        public string UpdateType { get; set; }

        [JsonProperty("CargoType")]
        public string CargoType { get; set; }

        [JsonProperty("CargoType_Localised")]
        public string CargoTypeLocalised { get; set; }

        [JsonProperty("Count")]
        public int Count { get; set; }

        [JsonProperty("StartMarketID")]
        public long StartMarketID { get; set; }

        [JsonProperty("EndMarketID")]
        public long EndMarketID { get; set; }

        [JsonProperty("ItemsCollected")]
        public int ItemsCollected { get; set; }

        [JsonProperty("ItemsDelivered")]
        public int ItemsDelivered { get; set; }

        [JsonProperty("TotalItemsToDeliver")]
        public int TotalItemsToDeliver { get; set; }

        [JsonProperty("Progress")]
        public float Progress { get; set; }

        public CargoDepot()
            : base(nameof(CargoDepot))
        {
        }
    }
}