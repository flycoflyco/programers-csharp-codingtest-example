using System;
using System.Collections.Generic;

namespace ConsoleApp34
{
	public class Program
	{
		public static void Main()
		{
			List<int> inputs = new List<int>();
			while (true)
			{
				string inputStr = Console.ReadLine();
				if (inputStr == "-1")
					break;

				inputs.Add(Convert.ToInt32(inputStr));
			}

			for ( int i = 0; i < inputs.Count; i++)
			{
				// int sum = GetSumFactor(inputs[i]);
				List<int> fl = GetFactorList(inputs[i]);
				int sum = GetSum(fl);
				if (sum == inputs[i])
				{
					PrintFactor(fl, sum);
				}
				else
				{
					Console.WriteLine(inputs[i] + " is NOT perfect.");
				}
			}
		}

		public static List<int> GetFactorList(int a)
		{
			List<int> result = new List<int>();
			
			for ( int i = 1; i < a; i++)
			{
				if ( a % i == 0)
				{
					result.Add(i);
				}
			}
			return result;
		}

		public static int GetSum(List<int> lst)
		{
			int result = 0;
			for (int i = 0; i < lst.Count; i++)
				result += lst[i];

			return result;
		}


		public static void PrintFactor (List<int> lst, int num)
		{
			Console.Write(num + " = ");
			for ( int i = 0; i <lst.Count; i++)
			{
				Console.Write(lst[i]+" ");
				if ( i < lst.Count-1)
				{
					Console.Write("+ ");
				}
			}
			Console.WriteLine();

		}


	}
}

