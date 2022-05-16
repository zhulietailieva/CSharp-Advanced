using System;

namespace StartUp
{
    public class Test
    {
        static void Main(string[] args)
        {
            //Testing CustomList structure
            CustomList customList = new CustomList();
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
            
         
        }
    }
}
