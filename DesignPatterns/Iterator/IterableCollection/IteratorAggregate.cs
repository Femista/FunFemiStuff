using System.Collections;

namespace Iterator.IterableCollection
{
    public abstract class IteratorAggregate : IEnumerable
    {
        public abstract IEnumerator GetEnumerator();
    }
}