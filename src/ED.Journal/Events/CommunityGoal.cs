using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class CommunityGoal : JournalEvent
    {
        [JsonProperty("CurrentGoals")]
        public CurrentGoal[] CurrentGoals { get; set; }

        public CommunityGoal()
            : base(nameof(CommunityGoal))
        {
        }
    }
}