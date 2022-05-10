using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public  class Family
    {
        List<Person> members;

        public Family(int members)
        {
            this.members = new List<Person>(members);
        }
        public List<Person> Members { get { return this.members; } set { this.members = value; } }

        public void AddMember(Person newMember)
        {
            members.Add(newMember);
        }
        public Person GetOldestMember()
        {
            Person oldestPerson=new Person();
            int oldestAge = -1;
            foreach (var member in members)
            {
                if (member.Age > oldestAge)
                {
                    oldestPerson = member;
                    oldestAge = member.Age;
                }
            }
            return oldestPerson;
        }
    }
}
