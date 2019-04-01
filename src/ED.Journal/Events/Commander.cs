using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class Commander : JournalEvent
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("FID")]
        public string Fid { get; set; }

        public Commander()
            : base(nameof(Commander))
        {
        }
    }
}