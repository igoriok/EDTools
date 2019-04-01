using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class EndCrewSession : JournalEvent
    {
        [JsonProperty("OnCrime")]
        public bool OnCrime { get; set; }

        public EndCrewSession()
            : base(nameof(EndCrewSession))
        {
        }
    }
}