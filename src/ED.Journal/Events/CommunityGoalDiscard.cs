using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class CommunityGoalDiscard : JournalEvent
    {
        [JsonProperty("CGID")]
        public long CGID { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("System")]
        public string System { get; set; }

        public CommunityGoalDiscard()
            : base(nameof(CommunityGoalDiscard))
        {
        }
    }
}