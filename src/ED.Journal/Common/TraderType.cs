using Newtonsoft.Json;

namespace ED.Journal
{
    public enum TraderType
    {
        [JsonProperty("raw")]
        Raw,
        
        [JsonProperty("encoded")]
        Encoded
    }
}