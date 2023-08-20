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
            int num = int.Parse(Console.ReadLine());
            List<Tuple<int, int>> coords = new List<Tuple<int, int>>();

            for (int i = 0; i < num; i++)
            {
                string coord = Console.ReadLine();
                string[] coordSplit = coord.Split(' ');
                int x = int.Parse(coordSplit[0]);
                int y = int.Parse(coordSplit[1]);
                Tuple<int, int> item = new Tuple<int, int>(x, y);
                coords.Add(item);
            }
            coords = coords.OrderBy(x => x.Item2).ThenBy(x => x.Item1).ToList();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < coords.Count; i++)
            {
                sb.AppendLine(coords[i].Item1 + " " + coords[i].Item2);
            }
            Console.WriteLine(sb.ToString());
        }
    }
}