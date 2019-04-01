using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class ClearSavedGame : JournalEvent
    {
        [JsonProperty("Name")]
        public string Name { get; set; }
        
        [JsonProperty("FID")]
        public string FID { get; set; }
        
        public ClearSavedGame()
            : base(nameof(ClearSavedGame))
        {
        }
    }
}