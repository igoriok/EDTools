using Newtonsoft.Json;

namespace ED.Journal
{
    public class Item
    {
        [JsonProperty("Slot")]
        public string Slot { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Name_Localised")]
        public string NameLocalised { get; set; }

        [JsonProperty("Hot")]
        public bool Hot { get; set; }

        [JsonProperty("EngineerModifications")]
        public string EngineerModifications { get; set; }

        [JsonProperty("Level")]
        public int Level { get; set; }

        [JsonProperty("Quality")]
        public float Quality { get; set; }
    }
}