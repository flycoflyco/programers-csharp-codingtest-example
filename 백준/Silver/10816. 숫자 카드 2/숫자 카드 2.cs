using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            string cards1 = Console.ReadLine();
            string[] cards1Split = cards1.Split(' ');

            int num2 = int.Parse(Console.ReadLine());
            string cards2 = Console.ReadLine();
            string[] cards2Split = cards2.Split(' ');

            Dictionary<string, int> dict = new Dictionary<string, int>();
            for (int i = 0; i < num1; i++)
            {
                string card = cards1Split[i];
                if (!dict.ContainsKey(card))
                    dict.Add(card, 1);
                else
                    dict[card]++;
            }

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < num2; i++)
            {
                string card2 = cards2Split[i];
                if (dict.ContainsKey(card2))
                    sb.Append(dict[card2].ToString());
                else
                    sb.Append("0");


                if (i != num2 - 1)
                    sb.Append(" ");
            }

            Console.WriteLine(sb.ToString());

        }
    }
}