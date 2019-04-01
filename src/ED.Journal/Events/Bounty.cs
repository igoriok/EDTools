using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class Bounty : JournalEvent
    {
        [JsonProperty("Faction")]
        public string Faction { get; set; }
        
        [JsonProperty("Target")]
        public string Target { get; set; }

        [JsonProperty("Reward")]
        public long Reward { get; set; }
        
        [JsonProperty("VictimFaction")]
        public string VictimFaction { get; set; }

//        [JsonProperty("TotalReward")]
//        public long TotalReward { get; set; }
//
//        [JsonProperty("SharedWithOthers")]
//        public long SharedWithOthers { get; set; }
//
//        [JsonProperty("Rewards")]
//        public Reward[] Rewards { get; set; }

        public Bounty()
            : base(nameof(Bounty))
        {
        }
    }
}