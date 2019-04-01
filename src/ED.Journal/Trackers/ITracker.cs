using ED.Journal.Events;

namespace ED.Journal.Trackers
{
    public interface ITracker
    {
        void Reset();
        
        void Track(JournalEvent @event);
    }
}