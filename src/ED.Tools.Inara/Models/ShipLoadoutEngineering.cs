using Newtonsoft.Json;

namespace ED.Tools.Inara.Models
{
    public class ShipLoadoutEngineering
    {
        [JsonProperty("blueprintName")]
        public string BlueprintName { get; }

        [JsonProperty("blueprintLevel")]
        public int BlueprintLevel { get; }

        [JsonProperty("blueprintQuality")]
        public int BlueprintQuality { get; }

        [JsonProperty("experimentalEffect")]
        public string ExperimentalEffect { get; }

        [JsonProperty("modifiers")]
        public ShipLoadoutEngineeringModifier[] Modifiers { get; }

        [JsonConstructor]
        public ShipLoadoutEngineering(string blueprintName, int blueprintLevel, int blueprintQuality, string experimentalEffect, ShipLoadoutEngineeringModifier[] modifiers)
        {
            BlueprintName = blueprintName;
            BlueprintLevel = blueprintLevel;
            BlueprintQuality = blueprintQuality;
            ExperimentalEffect = experimentalEffect;
            Modifiers = modifiers;
        }
    }
}