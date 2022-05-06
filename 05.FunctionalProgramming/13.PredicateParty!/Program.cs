using System;
using System.Collections.Generic;
using System.Linq;

namespace _13.PredicateParty_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<string> guests = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList<string>();
            string command;
            while ((command = Console.ReadLine()) != "Party!")
            {
                string[] cmndData = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (cmndData[0] == "Remove")
                {
                    string criteria = cmndData[1];
                    string partOfName = cmndData[2];
                    if(criteria == "StartsWith")
                    {
                        for (int i = 0; i < guests.Count; i++)
                        {
                            if (guests[i].StartsWith(partOfName))
                            {
                                guests.Remove(guests[i]);
                            }
                        }
                    }
                    else if (criteria == "EndsWith")
                    {
                        for (int i = 0; i < guests.Count; i++)
                        {
                            if (guests[i].EndsWith(partOfName))
                            {
                                guests.Remove(guests[i]);
                            }
                        }
                    }
                    else if (criteria == "Length")
                    {
                        int L = int.Parse(partOfName);
                        foreach (var guest in guests)
                        {
                            for (int i = 0; i < guests.Count; i++)
                            {
                                if (guests[i].Length==L)
                                {
                                    guests.Remove(guests[i]);
                                }
                            }
                        }
                    }
                }
                //
                else if (cmndData[0] == "Double")
                {
                    string criteria = cmndData[1];
                    string partOfName = cmndData[2];
                    if (criteria == "StartsWith")
                    {
                        int length = guests.Count;
                        for (int i = 0; i < length; i++)
                        {
                            if (guests[i].StartsWith(partOfName))
                            {
                                guests.Add(guests[i]);
                            }
                        }
                    }
                    else if (criteria == "EndsWith")
                    {
                        int length = guests.Count;
                        for (int i = 0; i < length; i++)
                        {
                            if (guests[i].EndsWith(partOfName))
                            {
                                guests.Add(guests[i]);
                            }
                        }
                    }
                    else if (criteria == "Length")
                    {
                        int L = int.Parse(partOfName);
                        int length = guests.Count;
                        for (int i = 0; i < length; i++)
                        {
                            if (guests[i].Length == L)
                            {
                                guests.Add(guests[i]);
                            }
                        }
                    }
                }
            }
            if (guests.Count == 0)
            {
                Console.WriteLine("Nobody is going to the party!");
            }
            else
            {
                Console.WriteLine($"{string.Join(", ",guests)} are going to the party!");
            }
        }
    }
}
