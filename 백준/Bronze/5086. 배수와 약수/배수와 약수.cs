using System;
using System.Collections.Generic;

namespace ConsoleApp34
{
	public class Program
	{
		public static void Main()
		{
			
			
			List<int[]> inputs = new List<int[]>();
			while (true)
			{
				string cmdLine = Console.ReadLine();
				string[] cmdLineSplit = cmdLine.Split(' ');
				if (cmdLineSplit[0] == "0" && cmdLineSplit[1] == "0")
					break;

				int[] pair = new int[2] { Convert.ToInt32(cmdLineSplit[0]), Convert.ToInt32(cmdLineSplit[1]) };
				inputs.Add(pair);
			}

			for ( int i = 0; i < inputs.Count;i++)
			{
				int[] item = inputs[i];
				int a = item[0];
				int b = item[1];

				string result = "neither";

				if (IsFactor(b, a))
					result = "factor";
				else if ( a % b == 0)
					result = "multiple";

				Console.WriteLine(result);
			}

			
		}

		public static bool IsFactor(int a, int b)
		{
			bool result = false;
			for ( int i = 1; i <= a; i++)
			{
				if ( a % i == 0 && i == b)
				{
					result = true;
					break;
				}
			}
			return result;
		}


	}
}

