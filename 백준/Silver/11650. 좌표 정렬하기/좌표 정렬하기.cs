using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {

        public static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());

            List<Tuple<int, int>> coords = new List<Tuple<int, int>>();
            for (int i = 0; i < inputNum; i++)
            {
                string cmdLine = Console.ReadLine();
                string[] cmdLineSplit = cmdLine.Split(' ');
                int x = int.Parse(cmdLineSplit[0]);
                int y = int.Parse(cmdLineSplit[1]);
                Tuple<int, int> item = new Tuple<int, int>(x, y);
                coords.Add(item);
            }

            coords = coords.OrderBy(t => t.Item1).ThenBy(t => t.Item2).ToList();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < inputNum; i++)
            {
                sb.AppendLine(coords[i].Item1.ToString() + " " + coords[i].Item2.ToString());
            }
            Console.Write(sb.ToString());
        }
    }
}