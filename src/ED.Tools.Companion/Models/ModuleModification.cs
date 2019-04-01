using Newtonsoft.Json;

namespace ED.Tools.Companion.Models
{
    public class ModuleModification
    {
        [JsonProperty("locName")]
        public string LocName { get; set; }
        
        [JsonProperty("value")]
        public float Value { get; set; }
        
        [JsonProperty("displayValue")]
        public string DisplayValue { get; set; }
        
        [JsonProperty("dir")]
        public string Dir { get; set; }
        
        [JsonProperty("LessIsGood")]
        public bool LessIsGood { get; set; }
    }
}