using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class PowerplayVote : JournalEvent
    {
        [JsonProperty("Power")]
        public string Power { get; set; }

        [JsonProperty("Votes")]
        public long Votes { get; set; }

        [JsonProperty("VoteToConsolidate")]
        public long VoteToConsolidate { get; set; }

        public PowerplayVote()
            : base(nameof(PowerplayVote))
        {
        }
    }
}
