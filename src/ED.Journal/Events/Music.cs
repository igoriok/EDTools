using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class Music : JournalEvent
    {
        [JsonProperty("MusicTrack")]
        public string MusicTrack { get; set; }

        public Music()
            : base(nameof(Music))
        {
        }
    }
}