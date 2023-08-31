using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            string nmStr = Console.ReadLine();
            string[] nmStrSplit = nmStr.Split(' ');
            int n = int.Parse(nmStrSplit[0]);
            int m = int.Parse(nmStrSplit[1]);
            Dictionary<string, int> dict1 = new Dictionary<string, int>();
            Dictionary<int, string> dict2 = new Dictionary<int, string>();

            for (int i = 1; i <= n; i++)
            {
                string poketmonName = Console.ReadLine();
                dict1.Add(poketmonName, i);
                dict2.Add(i, poketmonName);
            }

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < m; i++)
            {
                string findCmd = Console.ReadLine();
                int num = 0;
                if (int.TryParse(findCmd, out num))
                {
                    string name = dict2[num];
                    sb.AppendLine(name);
                }
                else
                {
                    int number = dict1[findCmd];
                    sb.AppendLine(number.ToString());
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}