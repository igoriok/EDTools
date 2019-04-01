namespace ED.Journal.Events
{
    public class HeatWarning : JournalEvent
    {
        public HeatWarning()
            : base(nameof(HeatWarning))
        {
        }
    }
}