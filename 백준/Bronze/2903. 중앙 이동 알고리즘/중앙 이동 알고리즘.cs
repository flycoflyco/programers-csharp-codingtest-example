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

			int temp = 3;

			for (int i = 1; i < input; i++)
			{
				temp = temp + (GetPow(2, i));
			}

			int result = temp * temp;
			Console.Write(result);

		}

		public static int GetPow(int num, int powNum)
		{
			int result = num;
			for ( int i = 0; i < powNum-1; i++)
			{
				result = result * num;
			}
			return result;
		}
	}
}

