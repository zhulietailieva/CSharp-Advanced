using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartUp
{
    public class CustomList
    {
        private int[] array;
        int counter;
        public CustomList()
        {
            array = new int[2];
            counter = 0;

        }
        public int Length 
        { 
            get 
            {
                return this.counter; 
            }  
        }
        public int this[int i]
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
        public void Add(int element)
        {
            Resize();
            array[counter] = element;
            counter++;
        }
        public int getElement(int index)
        {
            EnsureIndexIsInRange(index);
            return array[index];
        }
        public int RemoveAt(int index)
        {
            EnsureIndexIsInRange(index);
            counter--;
            for (int i = index; i < counter; i++)
            {
                array[i] = array[i + 1];
            }
            return array[index];
        }
        public bool Contains(int elemment)
        {
            for (int i = 0; i < counter; i++)
            {
                if (array[i] == elemment)
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
            int temp = array[firstIndex];
            array[firstIndex] = array[secondIndex];
            array[secondIndex] = temp;
        }
        public void Shrink()
        {
            int[] newArray = new int[counter];
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
                int[] copyArr = new int[array.Length * 2];
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
