using System;
using System.Collections.Generic;

namespace ConsoleApp34
{
	public class Program
	{
		public static void Main()
		{
			Dictionary<int, int> xDictionary = new Dictionary<int, int>();
			Dictionary<int, int> yDictionary = new Dictionary<int, int>();
			for ( int i = 0; i < 3; i++)
			{
				string inputStr = Console.ReadLine();
				string[] inputSplit = inputStr.Split(' ');
				int x = Convert.ToInt32(inputSplit[0]);
				int y = Convert.ToInt32(inputSplit[1]);

				if (xDictionary.ContainsKey(x))
					xDictionary[x]++;
				else
					xDictionary.Add(x, 1);

				if (yDictionary.ContainsKey(y))
					yDictionary[y]++;
				else
					yDictionary.Add(y, 1);
			}

			int xresult = 0;
			int yresult = 0;

			foreach ( int index in xDictionary.Keys)
			{
				if ( xDictionary[index] == 1)
					xresult = index;
			}

			foreach (int index in yDictionary.Keys)
			{
				if (yDictionary[index] == 1)
					yresult = index;
			}


			Console.WriteLine(xresult.ToString() + " " + yresult.ToString());

		}
	}
}

