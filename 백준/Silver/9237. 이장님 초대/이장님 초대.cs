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
			string[] inputSplit = inputStr2.Split();
			List<int> arr = new List<int>();

			for (int i = 0; i < inputSplit.Length; i++)
			{
				arr.Add(Convert.ToInt32(inputSplit[i]));
			}

			arr.Sort();
			arr.Reverse();

			int max = int.MinValue;

			for ( int i = 0; i < arr.Count; i++)
			{
				if ( max < arr[i] + i + 1)
				{
					max = arr[i] + i + 1;
				}
			}

			Console.WriteLine(max + 1);

		}

	}
}


