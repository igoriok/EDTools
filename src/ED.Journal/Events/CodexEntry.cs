using Newtonsoft.Json;

namespace ED.Journal.Events
{
    public class CodexEntry : JournalEvent
    {
        [JsonProperty("EntryID")]
        public long EntryID { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Name_Localised")]
        public string NameLocalised { get; set; }

        [JsonProperty("SubCategory")]
        public string SubCategory { get; set; }

        [JsonProperty("SubCategory_Localised")]
        public string SubCategoryLocalised { get; set; }

        [JsonProperty("Category")]
        public string Category { get; set; }

        [JsonProperty("Category_Localised")]
        public string CategoryLocalised { get; set; }

        [JsonProperty("Region")]
        public string Region { get; set; }

        [JsonProperty("Region_Localised")]
        public string RegionLocalised { get; set; }

        [JsonProperty("System")]
        public string System { get; set; }

        [JsonProperty("SystemAddress")]
        public long SystemAddress { get; set; }

        [JsonProperty("IsNewEntry")]
        public bool IsNewEntry { get; set; }

//        [JsonProperty("VoucherAmount")]
//        public long VoucherAmount { get; set; }
        
        [JsonProperty("NewTraitsDiscovered")]
        public bool NewTraitsDiscovered { get; set; }
        
        [JsonProperty("Traits")]
        public string[] Traits { get; set; }

        public CodexEntry()
            : base(nameof(CodexEntry))
        {
        }
    }
}