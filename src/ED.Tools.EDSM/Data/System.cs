using Newtonsoft.Json;

namespace ED.Tools.EDSM.Data
{
    public class System
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}