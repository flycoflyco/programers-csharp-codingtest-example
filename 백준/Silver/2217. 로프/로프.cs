using System;
using System.Collections.Generic;

namespace ConsoleApp34
{
	public class Program
	{
		public static void Main()
		{
			string inputStr = Console.ReadLine();
			int inputNumber = Convert.ToInt32(inputStr);
			List<int> numbers = new List<int>();
			for ( int i = 0; i < inputNumber; i++)
			{
				string indexNumStr = Console.ReadLine();
				int indexNum = Convert.ToInt32(indexNumStr);
				numbers.Add(indexNum);
			}
			numbers.Sort();
			numbers.Reverse();

			int max = int.MinValue;

			for ( int i = 0; i < numbers.Count; i++)
			{
				int weight = numbers[i] * (i + 1);

				if (max < weight)
				{
					max = weight;
				}
			}

			Console.WriteLine(max);

		}

	}
}


