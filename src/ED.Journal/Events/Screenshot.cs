using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class Screenshot : JournalEvent
    {
        [JsonProperty("Filename")]
        public string Filename { get; set; }

        [JsonProperty("Width")]
        public int Width { get; set; }

        [JsonProperty("Height")]
        public int Height { get; set; }

        [JsonProperty("System")]
        public string System { get; set; }

        [JsonProperty("Body")]
        public string Body { get; set; }

        [JsonProperty("Latitude")]
        public double Latitude { get; set; }

        [JsonProperty("Longitude")]
        public double Longitude { get; set; }

        [JsonProperty("Altitude")]
        public double Altitude { get; set; }

        [JsonProperty("Heading")]
        public long Heading { get; set; }
        
        public Screenshot()
            : base(nameof(Screenshot))
        {
        }
    }
}
