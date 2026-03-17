using KK.DesignPattern.Iterator.Iterators;
using System.Collections;

namespace KK.DesignPattern.Iterator.Collections
{
    internal class WordsCollection : IteratorAggregate
    {
        private readonly List<string> _collection = [];

        private bool _direction = false;

        public void ReverseDirection()
        {
            _direction = !_direction;
        }

        public List<string> GetItems()
        {
            return _collection;
        }

        public void AddItem(string item)
        {
            this._collection.Add(item);
        }

        public override IEnumerator GetEnumerator()
        {
            return new AlphabeticalOrderIterator(this, _direction);
        }
    }
}
