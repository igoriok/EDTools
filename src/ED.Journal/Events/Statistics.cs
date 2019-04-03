using ED.Journal.Statistics;
using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class Statistics : JournalEvent
    {
        [JsonProperty("Bank_Account")]
        public BankAccountStatistics BankAccount { get; set; }

        [JsonProperty("Combat")]
        public CombatStatistics Combat { get; set; }

        [JsonProperty("Crime")]
        public CrimeStatistics Crime { get; set; }

        [JsonProperty("Smuggling")]
        public SmugglingStatistics Smuggling { get; set; }

        [JsonProperty("Trading")]
        public TradingStatistics Trading { get; set; }

        [JsonProperty("Mining")]
        public MiningStatistics Mining { get; set; }

        [JsonProperty("Exploration")]
        public ExplorationStatistics Exploration { get; set; }

        [JsonProperty("Passengers")]
        public PassengersStatistics Passengers { get; set; }

        [JsonProperty("Search_And_Rescue")]
        public SearchAndRescueStatistics SearchAndRescue { get; set; }

//        [JsonProperty("TG_ENCOUNTERS")]
//        public TgEncounters TgEncounters { get; set; }

        [JsonProperty("Crafting")]
        public CraftingStatistics Crafting { get; set; }

        [JsonProperty("Crew")]
        public CrewStatistics Crew { get; set; }

        [JsonProperty("Multicrew")]
        public MulticrewStatistics Multicrew { get; set; }

        [JsonProperty("Material_Trader_Stats")]
        public MaterialTraderStatistics MaterialTraderStats { get; set; }

//        [JsonProperty("CQC")]
//        public Dictionary<string, double> CQC { get; set; }

        public Statistics()
            : base(nameof(Statistics))
        {
        }
    }
}
