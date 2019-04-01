using Newtonsoft.Json;

namespace ED.Journal
{
    public class StationEconomy
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Name_Localised")]
        public string NameLocalised { get; set; }

        [JsonProperty("Proportion")]
        public double Proportion { get; set; }
    }
}