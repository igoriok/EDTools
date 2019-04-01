using Newtonsoft.Json;

namespace ED.Journal.Statistics
{
    public class PassengersStatistics
    {
        [JsonProperty("Passengers_Missions_Accepted")]
        public int PassengersMissionsAccepted { get; set; }
        
        [JsonProperty("Passengers_Missions_Disgruntled")]
        public int PassengersMissionsDisgruntled { get; set; }
        
        [JsonProperty("Passengers_Missions_Bulk")]
        public int PassengersMissionsBulk { get; set; }

        [JsonProperty("Passengers_Missions_VIP")]
        public int PassengersMissionsVIP { get; set; }

        [JsonProperty("Passengers_Missions_Delivered")]
        public int PassengersMissionsDelivered { get; set; }

        [JsonProperty("Passengers_Missions_Ejected")]
        public int PassengersMissionsEjected { get; set; }
    }
}