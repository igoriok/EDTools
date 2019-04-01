using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class FighterRebuilt : JournalEvent
    {
        [JsonProperty("Loadout")]
        public string Loadout { get; set; }

        public FighterRebuilt()
            : base(nameof(FighterRebuilt))
        {
        }
    }
}
