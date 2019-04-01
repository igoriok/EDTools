using Newtonsoft.Json;

namespace ED.Tools.Inara.Models.Statistics
{
    public class BankAccountStatistics
    {
        [JsonProperty("Current_Wealth")]
        public int CurrentWealth { get; set; }

        [JsonProperty("Spent_On_Ships")]
        public int SpentOnShips { get; set; }

        [JsonProperty("Spent_On_Outfitting")]
        public int SpentOnOutfitting { get; set; }

        [JsonProperty("Spent_On_Repairs")]
        public int SpentOnRepairs { get; set; }

        [JsonProperty("Spent_On_Fuel")]
        public int SpentOnFuel { get; set; }

        [JsonProperty("Spent_On_Ammo_Consumables")]
        public int SpentOnAmmoConsumables { get; set; }

        [JsonProperty("Insurance_Claims")]
        public int InsuranceClaims { get; set; }

        [JsonProperty("Spent_On_Insurance")]
        public int SpentOnInsurance { get; set; }

        [JsonProperty("Owned_Ship_Count")]
        public int OwnedShipCount { get; set; }
    }
}