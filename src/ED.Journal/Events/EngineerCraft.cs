using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class EngineerCraft : JournalEvent
    {
        [JsonProperty("Engineer")]
        public string Engineer { get; set; }

        [JsonProperty("EngineerID")]
        public long EngineerID { get; set; }
        
        [JsonProperty("BlueprintName")]
        public string BlueprintName { get; set; }
        
        [JsonProperty("BlueprintID")]
        public long BlueprintID { get; set; }
        
        [JsonProperty("Slot")]
        public string Slot { get; set; }

        [JsonProperty("Module")]
        public string Module { get; set; }

        [JsonProperty("ApplyExperimentalEffect")]
        public string ApplyExperimentalEffect { get; set; }

        [JsonProperty("Ingredients")]
        public Material[] Ingredients { get; set; }

        [JsonProperty("Level")]
        public int Level { get; set; }

        [JsonProperty("Quality")]
        public float Quality { get; set; }

        [JsonProperty("ExperimentalEffect")]
        public string ExperimentalEffect { get; set; }

        [JsonProperty("ExperimentalEffect_Localised")]
        public string ExperimentalEffectLocalised { get; set; }

        [JsonProperty("Modifiers")]
        public Modifier[] Modifiers { get; set; }

        public EngineerCraft()
            : base(nameof(EngineerCraft))
        {
        }
    }
}