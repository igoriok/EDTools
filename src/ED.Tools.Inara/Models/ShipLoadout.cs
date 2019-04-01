using Newtonsoft.Json;

namespace ED.Tools.Inara.Models
{
    public class ShipLoadout
    {
        [JsonProperty("slotName")]
        public string SlotName { get; }

        [JsonProperty("itemName")]
        public string ItemName { get; }

        [JsonProperty("itemValue")]
        public int ItemValue { get; }

        [JsonProperty("itemHealth")]
        public float ItemHealth { get; }

        [JsonProperty("isOn")]
        public bool IsOn { get; }

        [JsonProperty("isHot")]
        public bool IsHot { get; }

        [JsonProperty("itemPriority")]
        public int ItemPriority { get; }

        [JsonProperty("itemAmmoClip")]
        public int ItemAmmoClip { get; }

        [JsonProperty("itemAmmoHopper")]
        public int ItemAmmoHopper { get; }

        [JsonProperty("engineering")]
        public ShipLoadoutEngineering Engineering { get; }

        [JsonConstructor]
        public ShipLoadout(
            string slotName, string itemName, int itemValue, float itemHealth,
            bool isOn, bool isHot, int itemPriority, int itemAmmoClip, int itemAmmoHopper,
            ShipLoadoutEngineering engineering = null)
        {
            SlotName = slotName;
            ItemName = itemName;
            ItemValue = itemValue;
            ItemHealth = itemHealth;
            IsOn = isOn;
            IsHot = isHot;
            ItemPriority = itemPriority;
            ItemAmmoClip = itemAmmoClip;
            ItemAmmoHopper = itemAmmoHopper;
            Engineering = engineering;
        }
    }
}