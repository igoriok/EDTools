using Newtonsoft.Json;

namespace ED.Journal
{
    public class Faction
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("FactionState")]
        public string FactionState { get; set; }

        [JsonProperty("Government")]
        public string Government { get; set; }

        [JsonProperty("Influence")]
        public double Influence { get; set; }

        [JsonProperty("Allegiance")]
        public string Allegiance { get; set; }
        
        [JsonProperty("Happiness")]
        public string Happiness { get; set; }

        [JsonProperty("Happiness_Localised")]
        public string HappinessLocalised { get; set; }
        
        [JsonProperty("MyReputation")]
        public float MyReputation { get; set; }

        [JsonProperty("PendingStates")]
        public FactionState[] PendingStates { get; set; }

        [JsonProperty("RecoveringStates")]
        public FactionState[] RecoveringStates { get; set; }

        [JsonProperty("ActiveStates")]
        public FactionState[] ActiveStates { get; set; }

        [JsonProperty("SquadronFaction")]
        public bool? SquadronFaction { get; set; }

        [JsonProperty("HappiestSystem")]
        public bool? HappiestSystem { get; set; }

        [JsonProperty("HomeSystem")]
        public bool? HomeSystem { get; set; }
    }
}