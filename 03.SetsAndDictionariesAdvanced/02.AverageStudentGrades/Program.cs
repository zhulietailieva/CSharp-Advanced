using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.AverageStudentGrades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numStudents=int.Parse(Console.ReadLine());
            Dictionary<string,List<decimal>> students = new Dictionary<string,List<decimal>>();
            for (int i = 0; i < numStudents; i++)
            {
                string[] studentData=Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
                string currName=studentData[0];
                decimal grade=decimal.Parse(studentData[1]);
                if (!students.ContainsKey(currName))
                {
                    students.Add(currName,new List<decimal> { grade});
                }
                else
                {
                    students[currName].Add(grade);
                }
            }
            foreach (var student in students)
            {
                Console.Write($"{student.Key} -> ");

                foreach (var studentGrade in student.Value)
                {
                    Console.Write($"{studentGrade:f2} ");
                }
                Console.WriteLine($"(avg: {student.Value.Average():f2})");
            }
        }
    }
}
