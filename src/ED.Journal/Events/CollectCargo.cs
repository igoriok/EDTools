using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class CollectCargo : JournalEvent
    {
        [JsonProperty("Type")]
        public string Type { get; set; }

        [JsonProperty("Type_Localised")]
        public string TypeLocalised { get; set; }

        [JsonProperty("Stolen")]
        public bool Stolen { get; set; }
        
        [JsonProperty("MissionID")]
        public long? MissionID { get; set; }

        public CollectCargo()
            : base(nameof(CollectCargo))
        {
        }
    }
}