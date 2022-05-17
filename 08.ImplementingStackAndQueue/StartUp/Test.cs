using System;

namespace StartUp
{
    public class Test
    {
        static void Main(string[] args)
        {
            //Testing CustomList structure
            CustomList<int> customList = new CustomList<int>();
            CustomList<string> customList1 = new CustomList<string>();

            customList1.Add("Hello");
            customList1.Add("Goodbye");
            Console.WriteLine(customList1.Contains("Hello"));
            Console.WriteLine(customList1.RemoveAt(1));
            Console.WriteLine(customList1.Contains("Goodbye"));

            customList.Add(7);
            customList.Add(2);
            customList.Add(3);
            Console.WriteLine(customList.RemoveAt(2));
            for (int i = 0; i < customList.Length; i++)
            {
                Console.WriteLine(customList[i]);
            }
            Console.WriteLine(customList.Contains(7));
            Console.WriteLine(customList.Contains(33));
            //Testing CustomStack structure
            CustomStack customStack = new CustomStack();
            customStack.Push(5);
            customStack.Push(2);
            Console.WriteLine(customStack.Peek());
            Console.WriteLine(customStack.Peek());
            customStack.ForEach(x =>
            {
                Console.WriteLine(x);
            });
            customStack.Pop();

            //Testing customQueue struscture
            CustomQueue customQueue = new CustomQueue();

            customQueue.Enqueue(1);
            customQueue.Enqueue(2);
            customQueue.Enqueue(3);
            customQueue.Enqueue(4);


            customQueue.ForEach(element =>
            {
                Console.WriteLine(element);
            });

            Console.WriteLine(customQueue.Peek());
             Console.WriteLine(customQueue.Dequeue());
            Console.WriteLine(customQueue.Dequeue());
            Console.WriteLine(customQueue.Dequeue());
            Console.WriteLine(customQueue.Dequeue());
           




        }
    }
}
