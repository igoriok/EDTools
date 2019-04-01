using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class ReservoirReplenished : JournalEvent
    {
        [JsonProperty("FuelMain")]
        public double FuelMain { get; set; }
        
        [JsonProperty("FuelReservoir")]
        public double FuelReservoir { get; set; }
        
        public ReservoirReplenished()
            : base(nameof(ReservoirReplenished))
        {
        }
    }
}