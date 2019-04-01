using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class EjectCargo : JournalEvent
    {
        [JsonProperty("Type")]
        public string Type { get; set; }

        [JsonProperty("Type_Localised")]
        public string TypeLocalised { get; set; }

        [JsonProperty("Count")]
        public long Count { get; set; }

        [JsonProperty("Abandoned")]
        public bool Abandoned { get; set; }
        
        [JsonProperty("MissionID")]
        public long? MissionID { get; set; }

        public EjectCargo()
            : base(nameof(EjectCargo))
        {
        }
    }
}