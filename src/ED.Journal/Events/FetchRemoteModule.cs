using System;
using ED.Journal.Converters;
using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class FetchRemoteModule : JournalEvent
    {
        [JsonProperty("StorageSlot")]
        public long StorageSlot { get; set; }

        [JsonProperty("StoredItem")]
        public string StoredItem { get; set; }

        [JsonProperty("StoredItem_Localised")]
        public string StoredItemLocalised { get; set; }

        [JsonProperty("ServerId")]
        public long ServerId { get; set; }

        [JsonProperty("TransferCost")]
        public long TransferCost { get; set; }

        [JsonProperty("Ship")]
        public string Ship { get; set; }

        [JsonProperty("ShipID")]
        public long ShipID { get; set; }

        [JsonProperty("TransferTime")]
        [JsonConverter(typeof(TimeSpanSecondsConverter))]
        public TimeSpan TransferTime { get; set; }
        
        public FetchRemoteModule()
            : base(nameof(FetchRemoteModule))
        {
        }
    }
}