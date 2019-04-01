using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class Fileheader : JournalEvent
    {
        [JsonProperty("part")]
        public int Part { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("gameversion")]
        public string Gameversion { get; set; }

        [JsonProperty("build")]
        public string Build { get; set; }

        public Fileheader()
            : base(nameof(Fileheader))
        {
        }
    }
}
