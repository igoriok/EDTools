using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class MiningRefined : JournalEvent
    {
        [JsonProperty("Type")]
        public string Type { get; set; }

        [JsonProperty("Type_Localised")]
        public string TypeLocalised { get; set; }

        public MiningRefined()
            : base(nameof(MiningRefined))
        {
        }
    }
}
