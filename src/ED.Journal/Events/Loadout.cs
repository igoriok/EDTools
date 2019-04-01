using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class Loadout : JournalEvent
    {
        [JsonProperty("Ship")]
        public string Ship { get; set; }

        [JsonProperty("ShipID")]
        public long ShipID { get; set; }

        [JsonProperty("ShipName")]
        public string ShipName { get; set; }

        [JsonProperty("ShipIdent")]
        public string ShipIdent { get; set; }

        [JsonProperty("HullValue")]
        public long HullValue { get; set; }

        [JsonProperty("ModulesValue")]
        public long ModulesValue { get; set; }

        [JsonProperty("HullHealth")]
        public float HullHealth { get; set; }

        [JsonProperty("Rebuy")]
        public long Rebuy { get; set; }
        
        [JsonProperty("Hot")]
        public bool Hot { get; set; }

        [JsonProperty("Modules")]
        public Module[] Modules { get; set; }

        public Loadout()
            : base(nameof(Loadout))
        {
        }
    }
}