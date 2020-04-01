using System.Collections;
using System.Collections.Generic;
using Iterator.Iterator;

namespace Iterator.IterableCollection
{
    public class WordsCollection : IteratorAggregate
    {
        readonly List<string> _collection = new List<string>();

        bool _direction;

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
            _collection.Add(item);
        }

        public override IEnumerator GetEnumerator()
        {
            return new AlphabeticalOrderIterator(this, _direction);
        }
    }
}