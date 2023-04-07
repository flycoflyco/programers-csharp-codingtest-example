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

			int num = Convert.ToInt32(inputSplit[0]);
			int order = Convert.ToInt32(inputSplit[1]);

			int result = GetOrderFactor(num, order);

			Console.WriteLine(result);
		}

		public static int GetOrderFactor(int a, int b)
		{
			int result = 0;
			int cnt = 0;
			for ( int i = 1; i <= a; i++)
			{
				if ( a % i == 0)
				{
					cnt++;
					if ( cnt == b)
					{
						result = i;
					}
				}
			}
			return result;
		}


	}
}

