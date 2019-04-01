using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class RestockVehicle : JournalEvent
    {
        [JsonProperty("Type")]
        public string Type { get; set; }

        [JsonProperty("Loadout")]
        public string Loadout { get; set; }

        [JsonProperty("Cost")]
        public long Cost { get; set; }

        [JsonProperty("Count")]
        public long Count { get; set; }

        public RestockVehicle()
            : base(nameof(RestockVehicle))
        {
        }
    }
}
