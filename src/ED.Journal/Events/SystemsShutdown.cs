namespace ED.Journal.Events
{
    public class SystemsShutdown : JournalEvent
    {
        public SystemsShutdown()
            : base(nameof(SystemsShutdown))
        {
        }
    }
}
