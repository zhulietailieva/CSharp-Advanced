using System;
using System.Collections.Generic;
using System.Text;

namespace _08.Threeuple
{
    internal class Threeuple<T1,T2,T3>
    {
        public Threeuple(T1 firstItem,T2 secondItem,T3 thirdItem)
        {
            Item1 = firstItem;
            Item2 = secondItem;
            item3 = thirdItem;
        }
        public T1 Item1 { get; set; }
        public T2 Item2 { get; set; }
        public T3 item3 { get; set; }
    }
}
