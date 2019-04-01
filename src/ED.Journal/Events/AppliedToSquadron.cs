using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class AppliedToSquadron : JournalEvent
    {
        [JsonProperty("SquadronName")]
        public string SquadronName { get; set; }

        public AppliedToSquadron()
            : base(nameof(AppliedToSquadron))
        {
        }
    }
}
