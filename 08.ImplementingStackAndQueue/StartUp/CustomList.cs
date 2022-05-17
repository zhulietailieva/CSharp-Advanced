using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartUp
{
    public class CustomList<T>
    {
        private T[] array;
        int counter;
        public CustomList()
        {
            array = new T[2];
            counter = 0;

        }
        public int Length 
        { 
            get 
            {
                return this.counter; 
            }  
        }
        public T this[int i]
        {
            get
            {
                EnsureIndexIsInRange(i);
                return array[i];
            }
            set
            {
                EnsureIndexIsInRange(i);
                array[i] = value;
            }
        }
        public void Add(T element)
        {
            Resize();
            array[counter] = element;
            counter++;
        }
        public T getElement(int index)
        {
            EnsureIndexIsInRange(index);
            return array[index];
        }
        public T RemoveAt(int index)
        {
            EnsureIndexIsInRange(index);
            counter--;
            for (int i = index; i < counter; i++)
            {
                array[i] = array[i + 1];
            }
            return array[index];
        }
        public bool Contains(T elemment)
        {
            for (int i = 0; i < counter; i++)
            {
                if (array[i].Equals( elemment))
                {
                    return true;
                }
            }
            return false;
        }
        public void Swap(int firstIndex,int secondIndex)
        {
            EnsureIndexIsInRange(firstIndex);
            EnsureIndexIsInRange(secondIndex);
            T temp = array[firstIndex];
            array[firstIndex] = array[secondIndex];
            array[secondIndex] = temp;
        }
        public void Shrink()
        {
            T[] newArray = new T[counter];
            for (int i = 0; i < counter; i++)
            {
                newArray[i] = array[i];
            }
            array = newArray;
        }
        private void Resize()
        {
            if (counter >= array.Length)
            {
                T[] copyArr = new T[array.Length * 2];
                for (int i = 0; i < array.Length; i++)
                {
                    copyArr[i] = array[i];
                }
                array = copyArr;
            }
        }
        private void EnsureIndexIsInRange(int index)
        {
            if (index < 0 || index >= counter)
            {
                throw new IndexOutOfRangeException();

            }
        }
    }
}
