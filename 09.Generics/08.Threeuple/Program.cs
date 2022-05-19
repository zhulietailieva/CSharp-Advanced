using System;

namespace _08.Threeuple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inp1 = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            //Adam Smith Wallstreet New York
            string name1 = inp1[0] + " " + inp1[1];
            string address = inp1[2];
            string city = inp1[3];
            if (inp1.Length > 4)
            {
                city += " " + inp1[4];
            }
            Threeuple<string, string, string> t1 = new Threeuple<string, string, string>(name1, address, city);

            string[] inp2 = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
            string name2 = inp2[0];
            double litersOfBeer = double.Parse(inp2[1]);
            bool isDrunk = true;
            if (inp2[2] == "not")
            {
                isDrunk = false;
            }
            string isDrunkStr;
            if (isDrunk)
            {
                isDrunkStr = "True";
            }
            else
            {
                isDrunkStr = "False";
            }
            Threeuple<string, double, string> t2 = new Threeuple<string, double, string>
                (name2, litersOfBeer, isDrunkStr);

            string[] inp3 = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string name3 = inp3[0];
            double balance = double.Parse(inp3[1]);
            string bankName = inp3[2];

            Threeuple<string, double, string> t3 = new Threeuple<string, double, string>
                (name3, balance, bankName);

            Console.WriteLine($"{t1.Item1} -> {t1.Item2} -> {t1.item3}");
            Console.WriteLine($"{t2.Item1} -> {t2.Item2} -> {t2.item3}");
            Console.WriteLine($"{t3.Item1} -> {t3.Item2} -> {t3.item3}");

        }
    }
}
