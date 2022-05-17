using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartUp
{
    public class CustomStack<T>
    {
        private const int InitialCapacity = 4;
        private T[] array;
         public CustomStack()
        {
            array = new T[InitialCapacity];
            Count = 0;
        }
        public int Count { get;private set; }
        
          
       
        public void Push(T element)
        {

            Resize();         
            array[Count] = element;
            Count++;
        }
        public T Pop()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException();
            }
            Count--;
            return array[Count];
        }
        public T Peek()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException();
            }
            return array[Count - 1];
        }
        public void ForEach(Action<T> action)
        {
            for (int i = 0; i < Count; i++)
            {
                action(array[i]);
            }
        }

        private void Resize()
        {
            if (Count==array.Length)
            {
                T[] copyArr = new T[array.Length * 2];
                for (int i = 0; i < array.Length; i++)
                {
                    copyArr[i] = array[i];
                }
                array = copyArr;
            }
           
        }

    }
//    void Push(int element) – Adds the given element to the stack
//int Pop() – Removes the last added element
//int Peek() – Returns the last element in the stack without removing it
//void ForEach(Action<int> action) – Goes through each of the elements in the stack
}

