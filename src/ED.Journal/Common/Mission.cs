using System;
using ED.Journal.Converters;
using Newtonsoft.Json;

namespace ED.Journal
{
    public class Mission
    {
        [JsonProperty("MissionID")]
        public string MissionID { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("PassengerMission")]
        public bool PassengerMission { get; set; }

        [JsonProperty("Expires")]
        [JsonConverter(typeof(TimeSpanSecondsConverter))]
        public TimeSpan Expires { get; set; }
    }
}