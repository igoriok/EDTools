namespace ED.Journal.Events
{
    public class Shutdown : JournalEvent
    {
        public Shutdown()
            : base(nameof(Shutdown))
        {
        }
    }
}
