﻿using System.Collections;

namespace Iterator.Iterator
{
    public abstract class Iterator : IEnumerator
    {
        object IEnumerator.Current
        {
            get { return Current(); }
        }

        // Returns the key of the current element
        public abstract int Key();

        // Returns the current element
        protected abstract object Current();

        // Move forward to next element
        public abstract bool MoveNext();

        // Rewinds the Iterator to the first element
        public abstract void Reset();
    }
}