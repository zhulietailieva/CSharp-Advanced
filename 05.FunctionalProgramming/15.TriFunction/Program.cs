using System;

namespace _15.TriFunction
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
           
            string[] names = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Func<string, int, bool> isNameEqualToLength = AreNameCharsEqualOrMoreThanN;

            for (int i = 0; i < names.Length; i++)
            {
                if (isNameEqualToLength(names[i], N))
                {
                    Console.WriteLine(names[i]);
                    return;
                }
            }
        }
        public static bool AreNameCharsEqualOrMoreThanN(string name,int N)
        {
            int sum = 0;
                for (int i = 0; i < name.Length; i++)
            {
                sum += (int)name[i];
            }
            if (sum >= N)
            {
                return true;
            }
            return false;
        }
        
    }
}
