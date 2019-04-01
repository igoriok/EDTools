using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class Rank : JournalEvent
    {
        [JsonProperty("Combat")]
        public int Combat { get; set; }

        [JsonProperty("Trade")]
        public int Trade { get; set; }

        [JsonProperty("Explore")]
        public int Explore { get; set; }

        [JsonProperty("Empire")]
        public int Empire { get; set; }

        [JsonProperty("Federation")]
        public int Federation { get; set; }

        [JsonProperty("CQC")]
        public int CQC { get; set; }

        public Rank()
            : base(nameof(Rank))
        {
        }
    }
}
