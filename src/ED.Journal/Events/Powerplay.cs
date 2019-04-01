using System;
using ED.Journal.Converters;
using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class Powerplay : JournalEvent
    {
        [JsonProperty("Power")]
        public string Power { get; set; }

        [JsonProperty("Rank")]
        public int Rank { get; set; }

        [JsonProperty("Merits")]
        public int Merits { get; set; }

        [JsonProperty("Votes")]
        public long Votes { get; set; }

        [JsonProperty("TimePledged")]
        [JsonConverter(typeof(TimeSpanSecondsConverter))]
        public TimeSpan TimePledged { get; set; }

        public Powerplay()
            : base(nameof(Powerplay))
        {
        }
    }
}
