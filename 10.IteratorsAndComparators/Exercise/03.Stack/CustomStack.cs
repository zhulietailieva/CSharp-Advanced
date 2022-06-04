using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _03.Stack
{
    public class CustomStack<T> :IEnumerable<T>
    {
        private List<T> collection;
        public CustomStack()
        {
            collection = new List<T>();
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = collection.Count-1; i >=0; i--)
            {
                yield return collection[i];
            }
        }

        public T Pop()
        {
            if (this.collection.Count == 0)
            {
                throw new InvalidOperationException("No elements");
            }
            var lastItem = collection[collection.Count - 1];
        collection.RemoveAt(collection.Count - 1);
            return lastItem;
        }
        public void Push(T[] items) 
        {
            for (int i = 0; i < items.Length; i++)
            {
                collection.Add(items[i]);
            }
        }

        internal void Push(T element)
        {
            collection.Add(element);
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
