using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class AfmuRepairs : JournalEvent
    {
        [JsonProperty("Module")]
        public string Module { get;  set; }

        [JsonProperty("Module_Localised")]
        public string ModuleLocalised { get;  set; }

        [JsonProperty("FullyRepaired")]
        public bool FullyRepaired { get;  set; }

        [JsonProperty("Health")]
        public double Health { get;  set; }

        public AfmuRepairs()
            : base(nameof(AfmuRepairs))
        {
        }
    }
}
