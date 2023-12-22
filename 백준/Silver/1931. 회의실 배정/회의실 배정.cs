using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
			int inputNum = int.Parse(input);
			List<Tuple<int, int>> items = new List<Tuple<int, int>>();

			for ( int i =0; i < inputNum; i++)
			{
				string cmdLine = Console.ReadLine();
				string[] splitStr = cmdLine.Split(' ');
				int startH = int.Parse(splitStr[0]);
				int endH = int.Parse(splitStr[1]);
				Tuple<int, int> tuple = new Tuple<int, int>(startH, endH);
				items.Add(tuple);
			}
			var temp = items.OrderBy(x => x.Item2).ThenBy(x => x.Item1).ToList();

			int result = 1;
			Tuple<int, int> start = temp[0];
			int currEndTime = start.Item2;
			for ( int i = 1; i < temp.Count; i++)
			{
				Tuple<int, int> currTime = temp[i];
				if (currTime.Item1 >= currEndTime)
				{
					currEndTime = currTime.Item2;
					result++;
				}
			}
			Console.WriteLine(result);
		}
    }
}