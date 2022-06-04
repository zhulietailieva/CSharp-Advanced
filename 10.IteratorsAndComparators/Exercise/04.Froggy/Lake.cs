using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _04.Froggy
{
    public class Lake : IEnumerable<int>
    {
        private List<int> list;
        public Lake(int[] numbers) 
        {
            list = new List<int>(numbers);
        }
        public string GetPath()
        {
            StringBuilder res = new StringBuilder();
            string evens = string.Join(", ", GetEvenPosNums());
            res.Append(evens);
            res.Append(", ");
            string odds = string.Join(", ", GetOddPosNumsRev());
            res.Append(odds);

            return res.ToString();

        }
        private List<int> GetEvenPosNums()
        {
            List<int> evenPosNums = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                if (i % 2 == 0)
                {
                    evenPosNums.Add(list[i]);
                }
            }
            return evenPosNums;
        }
        private List<int> GetOddPosNumsRev()
        {
            List<int> oddPosNums = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                if (i % 2 != 0)
                {
                    oddPosNums.Add(list[i]);
                }
            }
            oddPosNums.Reverse();
            return oddPosNums;
        }
        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < list.Count; i++)
            {
                yield return list[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
