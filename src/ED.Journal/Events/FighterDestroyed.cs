namespace ED.Journal.Events
{
    public class FighterDestroyed : JournalEvent
    {
        public FighterDestroyed()
            : base(nameof(FighterDestroyed))
        {
        }
    }
}