using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class HullDamage : JournalEvent
    {
        [JsonProperty("Health")]
        public double Health { get; set; }

        [JsonProperty("PlayerPilot")]
        public bool PlayerPilot { get; set; }

        [JsonProperty("Fighter")]
        public bool Fighter { get; set; }

        public HullDamage()
            : base(nameof(HullDamage))
        {
        }
    }
}