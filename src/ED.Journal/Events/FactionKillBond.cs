using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class FactionKillBond : JournalEvent
    {
        [JsonProperty("Reward")]
        public long Reward { get; set; }

        [JsonProperty("AwardingFaction")]
        public string AwardingFaction { get; set; }

        [JsonProperty("AwardingFaction_Localised")]
        public string AwardingFactionLocalised { get; set; }

        [JsonProperty("VictimFaction")]
        public string VictimFaction { get; set; }

        [JsonProperty("VictimFaction_Localised")]
        public string VictimFactionLocalised { get; set; }

        public FactionKillBond()
            : base(nameof(FactionKillBond))
        {
        }
    }
}