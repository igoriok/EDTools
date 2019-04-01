using Newtonsoft.Json;

namespace ED.Journal
{
    public class Passenger
    {
        [JsonProperty("MissionID")]
        public string MissionID { get; set; }

        [JsonProperty("Type")]
        public string Type { get;set; }

        [JsonProperty("VIP")]
        public bool VIP { get; set; }

        [JsonProperty("Wanted")]
        public bool Wanted { get; set; }

        [JsonProperty("Count")]
        public int Count { get; set; }
    }
}