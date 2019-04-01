using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class CommunityGoalJoin : JournalEvent
    {
        [JsonProperty("CGID")]
        public long CGID { get; set; }
        
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("System")]
        public string System { get; set; }

        public CommunityGoalJoin()
            : base(nameof(CommunityGoalJoin))
        {
        }
    }
}