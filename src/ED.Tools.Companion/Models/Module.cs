using Newtonsoft.Json;

namespace ED.Tools.Companion.Models
{
    public class Module
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        
        [JsonProperty("name")]
        public string Name { get; set; }
        
        [JsonProperty("locName")]
        public string LocName { get; set; }
        
        [JsonProperty("locDescription")]
        public string LocDescription { get; set; }
        
        [JsonProperty("value")]
        public long Value { get; set; }
        
        [JsonProperty("health")]
        public long Health { get; set; }

        [JsonProperty("free")]
        public bool Free { get; set; }
        
        [JsonProperty("on")]
        public bool On { get; set; }
        
        [JsonProperty("priority")]
        public int Priority { get; set; }
    }
}