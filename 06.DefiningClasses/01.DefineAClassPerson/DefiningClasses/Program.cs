using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Ivan";
            person.Age = 5;
            Console.WriteLine($"Name: {person.Name}, Age:{person.Age}");
        }
    }
}
