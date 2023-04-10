using System;
using System.Collections.Generic;

namespace ConsoleApp34
{
	public class Program
	{
		public static void Main()
		{
			string inputStr1 = Console.ReadLine();
			int input = Convert.ToInt32(inputStr1);
			int[] numList = GetAyksuList(input);
			for ( int i = 0; i < numList.Length; i++)
			{
				int num = numList[i];
				if ( CheckPrimeNumber(num) && input % num == 0)
				{
					Console.WriteLine(num);
					input = input / num;

					if (input == 1)
						break;

					i = 0;
					
				}
			}
		}
		public static int[] GetAyksuList(int n)
		{
			List<int> lst = new List<int>();
			for (int i = 1; i <= n; i++)
			{
				if (n % i == 0)
					lst.Add(i);
			}
			return lst.ToArray();
		}


		public static bool CheckPrimeNumber(int n)
		{
			bool result = true;

			if (n == 1)
				return false;

			for (int i = 1; i <= n; i++)
			{
				if ((i != 1 && i != n) && (n % i == 0))
				{
					result = false;
					break;
				}
			}
			return result;
		}
	}
}

