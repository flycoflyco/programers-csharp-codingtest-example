using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            string inputStr = Console.ReadLine();
            string[] inputStrSplit = inputStr.Split(' ');
            int min = int.Parse(inputStrSplit[0]);
            int max = int.Parse(inputStrSplit[1]);

            bool?[] c = Enumerable.Repeat<bool?>(null, max + 1).ToArray<bool?>();

            c[0] = false;
            c[1] = false;
            for (int i = 2; i <= max; i++)
            {
                if (c[i] == null)
                {
                    c[i] = true;
                    for (int j = i; j < c.Length; j = j + i)
                    {
                        if (j == i)
                            continue;

                        c[j] = false;
                    }
                }
            }
            StringBuilder sb = new StringBuilder();
            int cnt = 0;
            for (int i = min; i <= max; i++)
            {
                if (c[i] != null && c[i].Value)
                {
                    sb.AppendLine(i.ToString());
                    cnt++;
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}