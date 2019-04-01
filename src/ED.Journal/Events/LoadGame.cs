using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ED.Journal.Events
{
    public class LoadGame : JournalEvent
    {
        [JsonProperty("Commander")]
        public string Commander { get; set; }
        
        [JsonProperty("FID")]
        public string FID { get; set; }

        [JsonProperty("Horizons")]
        public bool Horizons { get; set; }

        [JsonProperty("Ship")]
        public string Ship { get; set; }

        [JsonProperty("Ship_Localised")]
        public string ShipLocalised { get; set; }

        [JsonProperty("ShipID")]
        public long ShipID { get; set; }

        [JsonProperty("StartLanded")]
        public bool? StartLanded { get; set; }
        
        [JsonProperty("StartDead")]
        public bool? StartDead { get; set; }
        
        [JsonProperty("ShipName")]
        public string ShipName { get; set; }

        [JsonProperty("ShipIdent")]
        public string ShipIdent { get; set; }

        [JsonProperty("FuelLevel")]
        public double FuelLevel { get; set; }

        [JsonProperty("FuelCapacity")]
        public double FuelCapacity { get; set; }

        [JsonProperty("GameMode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public GameMode GameMode { get; set; }

        [JsonProperty("Group")]
        public string Group { get; set; }

        [JsonProperty("Credits")]
        public long Credits { get; set; }

        [JsonProperty("Loan")]
        public long Loan { get; set; }

        public LoadGame()
            : base(nameof(LoadGame))
        {
        }
    }
}
