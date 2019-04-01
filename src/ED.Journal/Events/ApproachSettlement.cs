using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class ApproachSettlement : JournalEvent
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Name_Localised")]
        public string NameLocalised { get; set; }

        [JsonProperty("MarketID")]
        public long MarketID { get; set; }

        [JsonProperty("Latitude")]
        public double Latitude { get; set; }

        [JsonProperty("Longitude")]
        public double Longitude { get; set; }

        public ApproachSettlement()
            : base(nameof(ApproachSettlement))
        {
        }
    }
}