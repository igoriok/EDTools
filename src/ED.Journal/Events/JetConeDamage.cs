using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class JetConeDamage : JournalEvent
    {
        [JsonProperty("Module")]
        public string Module { get; set; }

        [JsonProperty("Module_Localised")]
        public string ModuleLocalised { get; set; }

        public JetConeDamage()
            : base(nameof(JetConeDamage))
        {
        }
    }
}