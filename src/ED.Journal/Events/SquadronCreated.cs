using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class SquadronCreated : JournalEvent
    {
        [JsonProperty("SquadronName")]
        public string SquadronName { get; set; }

        public SquadronCreated()
            : base(nameof(SquadronCreated))
        {
        }
    }
}
