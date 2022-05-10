using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();
            for (int i = 0; i < N; i++)
            {
                string[] inpData = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                Person person = new Person(inpData[0], int.Parse(inpData[1]));
                people.Add(person);
            }
            List<Person> peopleOlderThan30 = people.Where(person => (person.Age) > 30).ToList();
            peopleOlderThan30 = peopleOlderThan30.OrderBy(x => x.Name).ToList();
            foreach (var person in peopleOlderThan30)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
