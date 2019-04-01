using Newtonsoft.Json;

namespace ED.Journal
{
    public class Modifier
    {
        [JsonProperty("Label")]
        public string Label { get; set; }

        [JsonProperty("Value")]
        public float? Value { get; set; }

        [JsonProperty("OriginalValue")]
        public float? OriginalValue { get; set; }

        [JsonProperty("LessIsGood")]
        public bool? LessIsGood { get; set; }
    }
}