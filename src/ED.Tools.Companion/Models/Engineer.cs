using Newtonsoft.Json;

namespace ED.Tools.Companion.Models
{
    public class Engineer
    {
        [JsonProperty("engineerId")]
        public long EngineerId { get; set; }

        [JsonProperty("engineerName")]
        public string EngineerName { get; set; }

        [JsonProperty("recipeName")]
        public string RecipeName { get; set; }
        
        [JsonProperty("recipeLocName")]
        public string RecipeLocName { get; set; }
        
        [JsonProperty("recipeLocDescription")]
        public string RecipeLocDescription { get; set; }
        
        [JsonProperty("recipeLevel")]
        public int RecipeLevel { get; set; }
    }
}