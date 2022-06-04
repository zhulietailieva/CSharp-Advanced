﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _01.ListyIterator
{
    public class ListyIterator<T>
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
    }
}
