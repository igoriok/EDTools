using Newtonsoft.Json;

namespace ED.Journal
{
    public class TechnologyBrokerItem
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Name_Localised")]
        public string NameLocalised { get; set; }
    }
}