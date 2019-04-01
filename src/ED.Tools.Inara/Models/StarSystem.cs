using Newtonsoft.Json;

namespace ED.Tools.Inara.Models
{
    public class StarSystem
    {
        [JsonProperty("starsystemName")]
        public string StarSystemName { get; }

        [JsonConstructor]
        public StarSystem(string starSystemName)
        {
            StarSystemName = starSystemName;
        }
    }
}