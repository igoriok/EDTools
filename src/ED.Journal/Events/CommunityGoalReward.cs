using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class CommunityGoalReward : JournalEvent
    {
        [JsonProperty("CGID")]
        public long CGID { get; set; }
        
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("System")]
        public string System { get; set; }

        [JsonProperty("Reward")]
        public long Reward { get; set; }

        public CommunityGoalReward()
            : base(nameof(CommunityGoalReward))
        {
        }
    }
}