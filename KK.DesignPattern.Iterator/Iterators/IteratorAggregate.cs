using System.Collections;

namespace KK.DesignPattern.Iterator.Iterators
{
    internal abstract class IteratorAggregate : IEnumerable
    {
        public abstract IEnumerator GetEnumerator();
    }
}
