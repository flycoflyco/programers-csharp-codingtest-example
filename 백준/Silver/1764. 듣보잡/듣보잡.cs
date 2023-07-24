using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            string lineNumStr = Console.ReadLine();
            string[] linNumStrSplit = lineNumStr.Split(' ');
            int n = Convert.ToInt32(linNumStrSplit[0]);
            int m = Convert.ToInt32(linNumStrSplit[1]);
            SortedSet<string> nameList = new SortedSet<string>();
            for ( int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                nameList.Add(name);
            }


            SortedSet<string> answerList = new SortedSet<string>();
            for (int i = 0; i < m; i++)
            {
                string name = Console.ReadLine();
                if (nameList.Contains(name))
                {
                    answerList.Add(name);
                }
            }
            Console.WriteLine(answerList.Count);
            foreach (string index in answerList)
            {
                Console.WriteLine(index);
            }

        }
    }
}
