using System;
using System.Linq;

namespace _06.CustomComparator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Func<int, int, int> sortArray = (x, y) =>
              {
                  if (x % 2 == 0 && y % 2 != 0) return -1;
                  else if (x % 2 != 0 && y % 2 == 0) return 1;
                  else if (x > y) return 1;
                  else if (x < y) return -1;
                  return 0;

              };
          Array.Sort(arr, (x,y)=>sortArray(x,y));
            Console.WriteLine(String.Join(" ",arr));
        }
       
    }
}
