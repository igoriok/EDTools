namespace ED.Journal.Events
{
    public class WingJoin : JournalEvent
    {
//        [JsonProperty("Others")]
//        public List<string> Others { get; set; }

        public WingJoin()
            : base(nameof(WingJoin))
        {
        }
    }
}
