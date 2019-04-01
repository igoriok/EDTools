using Newtonsoft.Json;

namespace ED.Journal.Statistics
{
    public class CraftingStatistics
    {
        [JsonProperty("Spent_On_Crafting")]
        public int SpentOnCrafting { get; set; }

        [JsonProperty("Count_Of_Used_Engineers")]
        public int CountOfUsedEngineers { get; set; }

        [JsonProperty("Recipes_Generated")]
        public int RecipesGenerated { get; set; }

        [JsonProperty("Recipes_Generated_Rank_1")]
        public int RecipesGeneratedRank1 { get; set; }

        [JsonProperty("Recipes_Generated_Rank_2")]
        public int RecipesGeneratedRank2 { get; set; }

        [JsonProperty("Recipes_Generated_Rank_3")]
        public int RecipesGeneratedRank3 { get; set; }

        [JsonProperty("Recipes_Generated_Rank_4")]
        public int RecipesGeneratedRank4 { get; set; }

        [JsonProperty("Recipes_Generated_Rank_5")]
        public int RecipesGeneratedRank5 { get; set; }

        [JsonProperty("Recipes_Applied")]
        public int RecipesApplied { get; set; }

        [JsonProperty("Recipes_Applied_Rank_1")]
        public int RecipesAppliedRank1 { get; set; }

        [JsonProperty("Recipes_Applied_Rank_2")]
        public int RecipesAppliedRank2 { get; set; }

        [JsonProperty("Recipes_Applied_Rank_3")]
        public int RecipesAppliedRank3 { get; set; }

        [JsonProperty("Recipes_Applied_Rank_4")]
        public int RecipesAppliedRank4 { get; set; }

        [JsonProperty("Recipes_Applied_Rank_5")]
        public int RecipesAppliedRank5 { get; set; }

        [JsonProperty("Recipes_Applied_On_Previously_Modified_Modules")]
        public int RecipesAppliedOnPreviouslyModifiedModules { get; set; }
    }
}