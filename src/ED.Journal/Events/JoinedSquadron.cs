using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class JoinedSquadron : JournalEvent
    {
        [JsonProperty("SquadronName")]
        public string SquadronName { get; set; }

        public JoinedSquadron()
            : base(nameof(JoinedSquadron))
        {
        }
    }
}