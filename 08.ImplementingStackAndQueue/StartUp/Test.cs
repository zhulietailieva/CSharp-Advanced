using System;

namespace StartUp
{
    public class Test
    {
        static void Main(string[] args)
        {
            CustomList customList = new CustomList();
            customList.Add(7);
            customList.Add(2);
            customList.Add(3);
            Console.WriteLine(customList.RemoveAt(2));
            for (int i = 0; i < customList.Length; i++)
            {
                Console.WriteLine(customList[i]) ;
            }
            Console.WriteLine(customList.Contains(7));
            Console.WriteLine(customList.Contains(33));
         
        }
    }
}
