using System;
using ED.Journal.Converters;
using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class FSSSignalDiscovered : JournalEvent
    {
        [JsonProperty("SystemAddress")]
        public long SystemAddress { get; set; }

        [JsonProperty("SignalName")]
        public string SignalName { get; set; }

        [JsonProperty("SignalName_Localised")]
        public string SignalNameLocalised { get; set; }

        [JsonProperty("USSType")]
        public string USSType { get; set; }

        [JsonProperty("USSType_Localised")]
        public string USSTypeLocalised { get; set; }

        [JsonProperty("SpawningState")]
        public string SpawningState { get; set; }

        [JsonProperty("SpawningState_Localised")]
        public string SpawningStateLocalised { get; set; }

        [JsonProperty("SpawningFaction")]
        public string SpawningFaction { get; set; }

        [JsonProperty("SpawningFaction_Localised")]
        public string SpawningFactionLocalised { get; set; }
        
        [JsonProperty("ThreatLevel")]
        public int ThreatLevel { get; set; }

        [JsonProperty("TimeRemaining")]
        [JsonConverter(typeof(TimeSpanSecondsConverter))]
        public TimeSpan TimeRemaining { get; set; }
        
        [JsonProperty("IsStation")]
        public bool? IsStation { get; set; }

        public FSSSignalDiscovered()
            : base(nameof(FSSSignalDiscovered))
        {
        }
    }
}
