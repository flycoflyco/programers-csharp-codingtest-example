using System;
using System.Collections.Generic;

namespace ConsoleApp34
{
	public class Program
	{
		public static void Main()
		{
			string inputStr = Console.ReadLine();
			string[] inputSplit = inputStr.Split(' ');

			int x = Convert.ToInt32(inputSplit[0]);
			int y = Convert.ToInt32(inputSplit[1]);
			int w = Convert.ToInt32(inputSplit[2]);
			int h = Convert.ToInt32(inputSplit[3]);

			int xMin = 0;
			int xMax = w;
			int yMin = 0;
			int yMax = h;

			List<int> items = new List<int>();

			items.Add(Math.Abs(x - xMin));
			items.Add(Math.Abs(x - xMax));
			items.Add(Math.Abs(y - yMin));
			items.Add(Math.Abs(y - yMax));

			items.Sort();

			Console.WriteLine(items[0]);

		}
	}
}

