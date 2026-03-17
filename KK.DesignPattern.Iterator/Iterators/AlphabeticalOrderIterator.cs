using System.Drawing;
using KK.DesignPattern.Iterator.Collections;

namespace KK.DesignPattern.Iterator.Iterators
{
    internal class AlphabeticalOrderIterator() : Iterator
    {
        private readonly WordsCollection _collection;

        // Stores the current traversal position. An iterator may have a lot of
        // other fields for storing iteration state, especially when it is
        // supposed to work with a particular kind of collection.
        private int _position = -1;

        private readonly bool _reverse = false;

        public AlphabeticalOrderIterator(WordsCollection collection, bool reverse = false) : this()
        {
            this._collection = collection;
            this._reverse = reverse;

            if (reverse)
            {
                this._position = collection.GetItems().Count;
            }
        }

        public override object Current()
        {
            return this._collection.GetItems()[_position];
        }

        public override int Key()
        {
            return this._position;
        }

        public override bool MoveNext()
        {
            int updatedPosition = this._position + (this._reverse ? -1 : 1);

            if (updatedPosition >= 0 && updatedPosition < this._collection.GetItems().Count)
            {
                this._position = updatedPosition;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override void Reset()
        {
            this._position = this._reverse ? this._collection.GetItems().Count - 1 : 0;
        }
    }
}
