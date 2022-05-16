using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartUp
{
    public class CustomQueue
    {
        private const int InitialCapacity = 4;
        private const int StartIndex= 0;
        private int[] array;
        public CustomQueue()
        {
            array = new int[InitialCapacity];
           

        }
        
        public int Count { get; private set; }
        public void Enqueue(int element)
        {
            Resize();
            array[Count] = element;
            Count++;
            
        }
        public int Dequeue()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("The queue is empty!");
            }

            var firstElement = array[StartIndex];
            Count--;
            for (int i = 1; i < array.Length; i++)
            {
                array[i-1] = array[i ];
            }
            return firstElement;
            
            
        }
        public int Peek()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("The queue is empty!");

            }
            return array[StartIndex];
        }
        public void Clear()
        {
            while (Count > 0)
            {
                Dequeue();
            }
        }
        public void ForEach(Action<int> action)
        {
            for (int i = StartIndex; i < Count; i++)
            {
                action(array[i]);
            }
        }

        private void Resize()
        {
            if (array.Length == Count)
            {
                int[] copyArr = new int[array.Length * 2];
                for (int i = 0; i < array.Length; i++)
                {
                    copyArr[i] = array[i];

                }
                array = copyArr;
            }
        }
    }
}
