using System;
using System.Collections.Generic;

namespace ConsoleApp34
{
	public class Program
	{
		public static void Main()
		{
			string inputStr = Console.ReadLine();
			int input = Convert.ToInt32(inputStr);
			int result = GetFactorial(input);
			Console.WriteLine(result);
		}

		public static int GetFactorial(int n)
		{
			int result = 1;
			for (int i = 1; i <= n; i++)
			{
				result = result * i;
			}
			return result;
		}
	}
}