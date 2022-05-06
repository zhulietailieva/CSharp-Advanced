using System;
using System.Collections.Generic;
using System.Linq;

namespace _14.PartyReservationFilterModule
{
    internal class Program
    {
        static List<string> removedGuests = new List<string>();
        static void Main(string[] args)
        {
            List<string> guests = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList<string>();
            Func<string, List<string>, List<string>> filterGuests = FilterGuestList;
            string command = Console.ReadLine();
            while (command != "Print")
            {
                filterGuests(command, guests);
                command = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ",filterGuests(command,guests)));
        }
        public static List<string> FilterGuestList(string input,List<string> guests)
        {
            if(input== "Print")
            {
                return guests;
            }
            string[] inpData = input.Split(';');
            
            string command = inpData[0];
            string filterType = inpData[1];
            string parameterFilter = inpData[2];

          

            if (command == "Add filter")
            {
                if (filterType == "Starts with")
                {
                    for (int i = 0; i < guests.Count; i++)
                    {
                        if (guests[i].StartsWith(parameterFilter))
                        {
                            removedGuests.Add(guests[i]);
                            guests.Remove(guests[i]);
                            
                        }
                    }
                }
                else if (filterType == "Ends with")
                {
                    for (int i = 0; i < guests.Count; i++)
                    {
                        if (guests[i].EndsWith(parameterFilter))
                        {
                            removedGuests.Add(guests[i]);
                            guests.Remove(guests[i]);
                        }
                    }
                }
                else if (filterType == "Length")
                {
                    int L = int.Parse(parameterFilter);
                    for (int i = 0; i < guests.Count; i++)
                    {
                        if (guests[i].Length==L)
                        {
                            removedGuests.Add(guests[i]);
                            guests.Remove(guests[i]);
                        }
                    }
                }
                else if (filterType == "Contains")
                {
                    for (int i = 0; i < guests.Count; i++)
                    {
                        if (guests[i].Contains(parameterFilter))
                        {
                            removedGuests.Add(guests[i]);
                            guests.Remove(guests[i]);
                        }
                    }
                }
            }
            else if (command == "Remove filter")
            {
                if (filterType == "Starts with")
                {
                    for (int i = 0; i < removedGuests.Count; i++)
                    {
                        if (removedGuests[i].StartsWith(parameterFilter))
                        {
                            guests.Add(removedGuests[i]);
                            removedGuests.Remove(removedGuests[i]);
                            Console.WriteLine(string.Join("-",removedGuests));
                           
                        }
                    }
                }
                else if (filterType == "Ends with")
                {
                    for (int i = 0; i < removedGuests.Count; i++)
                    {
                        if (removedGuests[i].EndsWith(parameterFilter))
                        {
                            guests.Add(removedGuests[i]);
                            removedGuests.Remove(removedGuests[i]);
                        }
                    }
                }
                else if (filterType == "Length")
                {
                    int L = int.Parse(parameterFilter);
                    for (int i = 0; i < removedGuests.Count; i++)
                    {
                        if (removedGuests[i].Length==L)
                        {
                            guests.Add(removedGuests[i]);
                            removedGuests.Remove(removedGuests[i]);
                        }
                    }
                }
                else if (filterType == "Contains")
                {
                    for (int i = 0; i < removedGuests.Count; i++)
                    {
                        if (removedGuests[i].Contains(parameterFilter))
                        {
                            guests.Add(removedGuests[i]);
                            removedGuests.Remove(removedGuests[i]);
                        }
                    }
                }
            }
            return guests;
        }
    }
}
