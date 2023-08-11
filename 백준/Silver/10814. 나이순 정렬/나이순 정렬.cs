using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        
        public static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());
            List<Tuple<int, string, int>> ageNames = new List<Tuple<int, string, int>>();
            for ( int i = 0; i < inputNum; i++)
            {
                string cmdLine = Console.ReadLine();
                string[] cmdLineSplit = cmdLine.Split(' ');
                int age = int.Parse(cmdLineSplit[0]); // age
                string name = cmdLineSplit[1];
                Tuple<int, string, int> item = new Tuple<int, string, int>(age, name, i);
                ageNames.Add(item);
            }

            ageNames = ageNames.OrderBy(p => p.Item1).ThenBy(p => p.Item3).ToList();

            for ( int i = 0; i < inputNum; i++)
            {
                Console.WriteLine(ageNames[i].Item1.ToString() +" "+ ageNames[i].Item2);
            }

        }
    }
}