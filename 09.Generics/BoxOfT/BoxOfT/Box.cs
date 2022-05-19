namespace BoxOfT
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Box<T>
    {
        Stack<T> elements;
        public Box()
        {
            elements = new Stack<T>();

        }
        public int Count
        {
            get
            {
                return this.Count;
            }
        }
        public void Add(T element)
        {
            elements.Push(element);
        }
        public T Remove()
        {
            return elements.Pop();
        }

    }
}