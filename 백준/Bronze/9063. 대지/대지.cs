using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp34
{
	public class Program
	{
		public static void Main()
		{
			string inputStr = Console.ReadLine();
			int input = Convert.ToInt32(inputStr);
			List<int> xDict = new List<int>();
			List<int> yDict = new List<int>();

			for (int i = 0; i < input; i++)
			{
				string cmdStr = Console.ReadLine();
				string[] cmdSplit = cmdStr.Split(' ');
				int x = Convert.ToInt32(cmdSplit[0]);
				int y = Convert.ToInt32(cmdSplit[1]);

				if (!xDict.Contains(x))
					xDict.Add(x);

				if (!yDict.Contains(y))
					yDict.Add(y);
			}

			if ( xDict.Count > 1 && yDict.Count > 1)
			{
				// key 값중 제일 큰값과 작은값 뽑기
				int w = Math.Abs(xDict.Max() - xDict.Min());
				int h = Math.Abs(yDict.Max() - yDict.Min());
				Console.WriteLine(w * h);
			}
			else
			{
				Console.WriteLine("0");
			}

		}
	}
}

