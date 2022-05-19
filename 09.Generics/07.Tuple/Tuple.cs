using System;
using System.Collections.Generic;
using System.Text;


    public class Tuple<T1,T2>
    {
        public Tuple(T1 firstItem, T2 secondItem)
        {
        Item1 = firstItem;
        Item2 = secondItem;
        }
    public T1 Item1 { get; set; }
    public T2 Item2 { get; set; }
    
    }

