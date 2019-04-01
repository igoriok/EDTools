using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class JetConeBoost : JournalEvent
    {
        [JsonProperty("BoostValue")]
        public double BoostValue { get; set; }

        public JetConeBoost()
            : base(nameof(JetConeBoost))
        {
        }
    }
}