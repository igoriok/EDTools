using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class UnderAttack : JournalEvent
    {
        [JsonProperty("Target")]
        public string Target { get; set; }

        public UnderAttack()
            : base(nameof(UnderAttack))
        {
        }
    }
}
