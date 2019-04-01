using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class FuelScoop : JournalEvent
    {
        [JsonProperty("Scooped")]
        public double Scooped { get; set; }

        [JsonProperty("Total")]
        public double Total { get; set; }

        public FuelScoop()
            : base(nameof(FuelScoop))
        {
        }
    }
}