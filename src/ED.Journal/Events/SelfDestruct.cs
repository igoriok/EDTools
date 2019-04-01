namespace ED.Journal.Events
{
    public class SelfDestruct : JournalEvent
    {
        public SelfDestruct()
            : base(nameof(SelfDestruct))
        {
        }
    }
}
