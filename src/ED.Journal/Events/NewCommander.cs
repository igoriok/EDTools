using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class NewCommander : JournalEvent
    {
        [JsonProperty("Name")]
        public string Name { get; set; }
        
        [JsonProperty("FID")]
        public string FID { get; set; }

        [JsonProperty("Package")]
        public string Package { get; set; }

        public NewCommander()
            : base(nameof(NewCommander))
        {
        }
    }
}
