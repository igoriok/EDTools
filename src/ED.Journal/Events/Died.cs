using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class Died : JournalEvent
    {
        [JsonProperty("KillerName")]
        public string KillerName { get; set; }

        [JsonProperty("KillerName_Localised")]
        public string KillerNameLocalised { get; set; }

        [JsonProperty("KillerShip")]
        public string KillerShip { get; set; }

        [JsonProperty("KillerRank")]
        public string KillerRank { get; set; }

        [JsonProperty("Killers")]
        public Killer[] Killers { get; set; }

        public Died()
            : base(nameof(Died))
        {
        }
    }
}