using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    internal class Person
    {
        string name;
        int age;
        public string Name { get { return this.name; } set { this.name = value; } }
        public int Age { get { return this.age; } set { this.age = value; } }
    }
}
