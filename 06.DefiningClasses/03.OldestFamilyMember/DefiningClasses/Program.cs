using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            Family family = new Family(N) ;
            for (int i = 0; i < N; i++)
            {
                string[] inpData = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                Person person = new Person(inpData[0], int.Parse(inpData[1]));
                family.AddMember(person);
            }
            Console.WriteLine(family.GetOldestMember().Name+" "+family.GetOldestMember().Age);
        }
    }
}
