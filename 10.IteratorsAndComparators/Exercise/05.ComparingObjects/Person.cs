using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace _05.ComparingObjects
{
    public class Person : IComparable<Person>
    {
        private string name;
        private int age;
        private string town;

        public string Name { get { return this.name; } }
        public int Age { get { return this.age; } }
        public string Town { get { return this.town; } }
        public Person(string name,int age,string town)
        {
            this.name = name;
            this.age = age;
            this.town = town;
        }

        public int CompareTo( Person other)
        {
            int res = this.Name.CompareTo(other.Name);
            if (res == 0)
            {
                res = this.Age.CompareTo(other.Age);
                if (res == 0)
                {
                    return this.Town.CompareTo(other.Town);
                }
                return res;
            }
            return res;
        }
    }
}
