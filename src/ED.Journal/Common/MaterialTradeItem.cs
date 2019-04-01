using Newtonsoft.Json;

namespace ED.Journal
{
    public class MaterialTradeItem
    {
        [JsonProperty("Material")]
        public string Material { get; set; }

        [JsonProperty("Material_Localised")]
        public string MaterialLocalised { get; set; }

        [JsonProperty("Category")]
        public MaterialCategory Category { get; set; }

        [JsonProperty("Quantity")]
        public long Quantity { get; set; }
    }
}