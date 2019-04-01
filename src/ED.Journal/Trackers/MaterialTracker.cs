using System.Collections.Generic;
using ED.Journal.Events;

namespace ED.Journal.Trackers
{
    public class MaterialTracker : ITracker
    {
        private bool _isInitialized = false;

        public Dictionary<string, int> Materials { get; }

        public MaterialTracker()
        {
            Materials = new Dictionary<string, int>();
        }

        public void Reset()
        {
            Materials.Clear();
            _isInitialized = false;
        }

        public void Track(JournalEvent @event)
        {
            if (@event is Materials materials)
            {
                Materials.Clear();

                foreach (var material in materials.Raw)
                {
                    this[material.Name] = material.Count;
                }

                foreach (var material in materials.Encoded)
                {
                    this[material.Name] = material.Count;
                }

                foreach (var material in materials.Manufactured)
                {
                    this[material.Name] = material.Count;
                }

                _isInitialized = true;
            }
            else if (!_isInitialized)
            {
                // do nothing
                return;
            }

            if (@event is MaterialCollected materialCollected)
            {
                this[materialCollected.Name] += materialCollected.Count;
            }
            else if (@event is MaterialDiscarded materialDiscarded)
            {
                this[materialDiscarded.Name] -= materialDiscarded.Count;
            }
            else if (@event is MissionCompleted missionCompleted)
            {
                if (missionCompleted.MaterialsReward?.Length > 0)
                {
                    foreach (var reward in missionCompleted.MaterialsReward)
                    {
                        this[reward.Name] += reward.Count;
                    }
                }
            }
            else if (@event is Synthesis synthesis)
            {
                foreach (var material in synthesis.Materials)
                {
                    this[material.Name] -= material.Count;
                }
            }
            else if (@event is EngineerCraft engineerCraft)
            {
                foreach (var material in engineerCraft.Ingredients)
                {
                    this[material.Name] -= material.Count;
                }
            }
            else if (@event is EngineerContribution engineerContribution)
            {
                // TODO
            }
        }

        private int this[string name]
        {
            get
            {
                Materials.TryGetValue(name, out var value);
                return value;
            }
            set => Materials[name] = value;
        }
    }
}