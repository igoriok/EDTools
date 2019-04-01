using System;
using System.Collections.Generic;
using ED.Journal.Events;

namespace ED.Journal.Trackers
{
    public class MinorFactionReputationTracker : ITracker
    {
        private readonly Dictionary<string, MinorFactionReputation> _reputation = new Dictionary<string, MinorFactionReputation>();

        public IReadOnlyCollection<MinorFactionReputation> Reputation => _reputation.Values;

        public void Reset()
        {
            _reputation.Clear();
        }

        public void Track(JournalEvent @event)
        {
            if (@event is Location location)
            {
                foreach (var faction in location.Factions ?? new Faction[0])
                {
                    _reputation[faction.Name] = new MinorFactionReputation(faction.Name, faction.MyReputation, location.Timestamp);
                }
            }
            else if (@event is FSDJump fsdJump)
            {
                foreach (var faction in fsdJump.Factions ?? new Faction[0])
                {
                    _reputation[faction.Name] = new MinorFactionReputation(faction.Name, faction.MyReputation, fsdJump.Timestamp);
                }
            }
        }

        public class MinorFactionReputation
        {
            public string FactionName { get; }

            public float Reputation { get; }

            public DateTime Timestamp { get; }

            public MinorFactionReputation(string factionName, float reputation, DateTime timestamp)
            {
                FactionName = factionName;
                Reputation = reputation;
                Timestamp = timestamp;
            }
        }
    }
}