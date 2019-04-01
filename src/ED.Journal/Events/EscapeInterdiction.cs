using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class EscapeInterdiction : JournalEvent
    {
        [JsonProperty("Interdictor")]
        public string Interdictor { get; set; }

        [JsonProperty("Interdictor_Localised")]
        public string InterdictorLocalised { get; set; }

        [JsonProperty("IsPlayer")]
        public bool IsPlayer { get; set; }

        public EscapeInterdiction()
            : base(nameof(EscapeInterdiction))
        {
        }
    }
}
