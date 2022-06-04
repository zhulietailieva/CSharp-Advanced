using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _02.Collection
{
    public class ListyIterator<T> :IEnumerable<T>
    {
        private readonly List<T> collection;
        private int currentIndex;

        public ListyIterator()
            : this(new List<T>())
        { }

        public ListyIterator(IEnumerable<T> collection)
        {
            this.collection = new List<T>(collection);
            currentIndex = 0;
        }

        public bool Move()
        {
            var canMove = this.HasNext();
            if (canMove)
            {
                currentIndex++;
            }
            return canMove;
        }

        public bool HasNext() => this.currentIndex < this.collection.Count - 1;

        public void Print()
        {
            if (this.collection.Count == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }
            Console.WriteLine(this.collection[this.currentIndex]);
        }
        public string PrintAll()
        {
            if (this.collection.Count == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < collection.Count; i++)
            {
                result.Append(collection[i]);
                if (i < collection.Count - 1)
                {
                    result.Append(" ");
                }
            }
            return result.ToString();
        }
        public IEnumerator<T> GetEnumerator()
        {
            yield return collection[currentIndex];
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
