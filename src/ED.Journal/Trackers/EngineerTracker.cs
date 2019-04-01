using System;
using System.Collections.Generic;
using ED.Journal.Events;

namespace ED.Journal.Trackers
{
    public class EngineerTracker : ITracker
    {
        private readonly Dictionary<long, EngineerRank> _engineers = new Dictionary<long, EngineerRank>();

        public IReadOnlyCollection<EngineerRank> Engineers => _engineers.Values;

        public void Reset()
        {
            _engineers.Clear();
        }

        public void Track(JournalEvent @event)
        {
            if (@event is EngineerProgress engineerProgress)
            {
                foreach (var engineer in engineerProgress.Engineers)
                {
                    _engineers[engineer.EngineerID] = new EngineerRank(engineer.Name, engineer.EngineerID, engineer.Progress, engineer.Rank, engineerProgress.Timestamp);
                }
            }
        }

        public class EngineerRank
        {
            public string Name { get; }

            public long EngineerID { get; }

            public string Progress { get; private set; }

            public int? Rank { get; private set; }

            public DateTime Timestamp { get; private set; }

            public EngineerRank(string name, long engineerID, string progress, int? rank, DateTime timestamp)
            {
                Timestamp = timestamp;
                Name = name;
                EngineerID = engineerID;
                Progress = progress;
                Rank = rank;
            }
        }
    }
}