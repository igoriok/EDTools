using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class SAAScanComplete : JournalEvent
    {
        [JsonProperty("BodyName")]
        public string BodyName { get; set; }

        [JsonProperty("BodyID")]
        public long BodyID { get; set; }

        [JsonProperty("ProbesUsed")]
        public int ProbesUsed { get; set; }

        [JsonProperty("EfficiencyTarget")]
        public int EfficiencyTarget { get; set; }

        public SAAScanComplete()
            : base(nameof(SAAScanComplete))
        {
        }
    }
}
