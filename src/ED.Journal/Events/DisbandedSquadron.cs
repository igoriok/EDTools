using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class DisbandedSquadron : JournalEvent
    {
        [JsonProperty("SquadronName")]
        public string SquadronName { get; set; }

        public DisbandedSquadron()
            : base(nameof(DisbandedSquadron))
        {
        }
    }
}