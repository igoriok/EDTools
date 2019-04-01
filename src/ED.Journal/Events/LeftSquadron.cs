using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class LeftSquadron : JournalEvent
    {
        [JsonProperty("SquadronName")]
        public string SquadronName { get; set; }

        public LeftSquadron()
            : base(nameof(LeftSquadron))
        {
        }
    }
}
