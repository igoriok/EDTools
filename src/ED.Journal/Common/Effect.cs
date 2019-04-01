using Newtonsoft.Json;

namespace ED.Journal
{
    public class Effect
    {
        [JsonProperty("Effect")]
        public string EffectEffect { get; set; }

        [JsonProperty("Effect_Localised")]
        public string EffectLocalised { get; set; }

        [JsonProperty("Trend")]
        public string Trend { get; set; }
    }
}