using System.Collections.Generic;
using ED.Journal.Events;

namespace ED.Journal.Trackers
{
    public class CargoTracker : ITracker
    {
        private bool _isInitialized;
        private readonly List<Inventory> _items = new List<Inventory>();

        public IReadOnlyList<Inventory> Items => _items;

        public void Reset()
        {
            _items.Clear();
            _isInitialized = false;
        }

        public void Track(JournalEvent @event)
        {
            if (@event is Cargo cargo)
            {
                _items.Clear();
                
                foreach (var inventory in cargo.Inventory)
                {
                    _items.Add(new Inventory
                    {
                        Name = inventory.Name,
                        NameLocalised = inventory.NameLocalised,
                        Count = inventory.Count,
                        Stolen = inventory.Stolen,
                    });
                }

                _isInitialized = true;
            }
            else if (!_isInitialized)
            {
                // do nothing
                return;
            }

            if (@event is MiningRefined miningRefined)
            {
                // TODO
            }
            else if (@event is SellDrones sellDrones)
            {
                // TODO
            }
        }
    }
}