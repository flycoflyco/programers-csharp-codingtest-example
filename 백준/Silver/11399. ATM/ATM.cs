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

			string[] inputSplit = inputStr2.Split(' ');
			int[] arr = new int[inputSplit.Length];

			for (int i = 0; i < inputSplit.Length; i++)
			{
				arr[i] = Convert.ToInt32(inputSplit[i]);
			}

			List<int> timeList = new List<int>(arr);
			timeList.Sort();

			int totalSum = 0;
			for (int  i = 0; i < timeList.Count; i++)
			{
				int indexSum = 0;
				for ( int j = 0; j <= i; j++)
				{
					indexSum += timeList[j];
				}
				totalSum += indexSum;
			}

			Console.WriteLine(totalSum);
			// 1, 2, 3, 3, 4;
			// 1, 3 , 6, 9, 13
			// 32;
		}

	}
}


