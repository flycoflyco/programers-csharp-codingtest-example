using System;
using System.Collections.Generic;

namespace ConsoleApp34
{
	public class Program
	{
		public static void Main()
		{
			int result = 0;
			string inputStr = Console.ReadLine();
			string[] inputSplit = inputStr.Split(' ');
			int a = Convert.ToInt32(inputSplit[0]);
			int b = Convert.ToInt32(inputSplit[1]);
			int c = Convert.ToInt32(inputSplit[2]);

			if (b == c)
			{
				result = -1;
			}
			else
			{
				int bp = a / (c - b);

				if (bp < 0)
					result = -1;
				else
					result = bp + 1;
			}

			Console.WriteLine(result);
		}

	}
}


