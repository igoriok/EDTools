using Newtonsoft.Json;

namespace ED.Tools.Inara.Models
{
    public class RewardPermit : StarSystem
    {
        [JsonConstructor]
        public RewardPermit(string starSystemName)
            : base(starSystemName)
        {
        }
    }
}