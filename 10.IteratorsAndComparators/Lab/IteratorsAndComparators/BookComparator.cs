using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace IteratorsAndComparators
{
    public class BookComparator : IComparer<Book>
    {
        public int Compare( Book x,  Book y)
        {
            int res = x.Title.CompareTo(y.Title);
            if (res == 0)
            {
                return x.Year.CompareTo(y.Year);
            }
            return res;
        }
    }
}
