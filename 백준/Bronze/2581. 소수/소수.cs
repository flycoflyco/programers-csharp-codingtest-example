using System;
using System.Collections.Generic;

namespace ConsoleApp34
{
	public class Program
	{
		public static void Main()
		{
			string inputStr1 = Console.ReadLine();
			string inputStr2 = Console.ReadLine();

			int startNum = Convert.ToInt32(inputStr1);
			int endNum = Convert.ToInt32(inputStr2);


			int result = 0;
			int min = int.MaxValue;

			for (int i = startNum; i <= endNum; i++)
			{
				if (IsPrimeNum(i))
				{
					result += i;
					if (min > i)
					{
						min = i;
					}
				}
			}

			if ( result == 0)
			{
				Console.WriteLine("-1");
			}
			else
			{
				Console.WriteLine(result);
				Console.WriteLine(min);
			}
		}

		public static bool IsPrimeNum (int num)
		{
			if (num == 1)
				return false;

			bool result = false;
			int cnt = 0;

			for (int i = 1; i <= num; i++)
			{
				if (num % i == 0)
				{
					cnt++;
					if (cnt > 2)
						break;
				}
			}

			if (cnt > 2)
				result = false;
			else
				result = true;

			return result;
		}




	}
}

