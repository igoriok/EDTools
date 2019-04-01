using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class Interdicted : JournalEvent
    {
        [JsonProperty("Submitted")]
        public bool Submitted { get; set; }

        [JsonProperty("Interdictor")]
        public string Interdictor { get; set; }

        [JsonProperty("Interdictor_Localised")]
        public string InterdictorLocalised { get; set; }

        [JsonProperty("IsPlayer")]
        public bool IsPlayer { get; set; }

        [JsonProperty("Faction")]
        public string Faction { get; set; }
        
        [JsonProperty("Power")]
        public string Power { get; set; }

        public Interdicted()
            : base(nameof(Interdicted))
        {
        }
    }
}