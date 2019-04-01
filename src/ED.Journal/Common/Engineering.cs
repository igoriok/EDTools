using Newtonsoft.Json;

namespace ED.Journal
{
    public class Engineering
    {
        [JsonProperty("EngineerID")]
        public long EngineerID { get; set; }
        
        [JsonProperty("Engineer")]
        public string Engineer { get; set; }

        [JsonProperty("BlueprintID")]
        public long BlueprintID { get; set; }

        [JsonProperty("BlueprintName")]
        public string BlueprintName { get; set; }

        [JsonProperty("Level")]
        public int Level { get; set; }

        [JsonProperty("Quality")]
        public float Quality { get; set; }

        [JsonProperty("ExperimentalEffect", NullValueHandling = NullValueHandling.Ignore)]
        public string ExperimentalEffect { get; set; }

        [JsonProperty("ExperimentalEffect_Localised", NullValueHandling = NullValueHandling.Ignore)]
        public string ExperimentalEffectLocalised { get; set; }

        [JsonProperty("Modifiers")]
        public Modifier[] Modifiers { get; set; }
    }
}