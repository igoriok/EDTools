using Newtonsoft.Json;

namespace ED.Tools.Inara.Models
{
    public class ShipLoadoutEngineeringModifier
    {
        [JsonProperty("name")]
        public string Name { get; }

        [JsonProperty("value")]
        public float Value { get; }

        [JsonProperty("originalValue")]
        public float OriginalValue { get; }

        [JsonProperty("lessIsGood")]
        public bool LessIsGood { get; }

        [JsonConstructor]
        public ShipLoadoutEngineeringModifier(string name, float value, float originalValue, bool lessIsGood)
        {
            Name = name;
            Value = value;
            OriginalValue = originalValue;
            LessIsGood = lessIsGood;
        }
    }
}