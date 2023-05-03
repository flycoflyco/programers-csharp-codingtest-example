using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp34
{
	public class Program
	{
		public static void Main()
		{
			int result = -1;
			string inputStr = Console.ReadLine();
			List<int> inputNums = new List<int>();

			int sum = 0;
			for (int i = 0; i < inputStr.Length; i++)
			{
				int index = Convert.ToInt32(inputStr[i].ToString());
				inputNums.Add(index);
				sum += index;
			}

			if (!inputNums.Contains(0) || (sum % 3 != 0))
			{
				Console.WriteLine(result);
				return;
			}

			inputNums.Sort();
			inputNums.Reverse();

			StringBuilder sb = new StringBuilder();
			
			for (int i = 0; i < inputNums.Count; i++)
			{
				sb.Append(inputNums[i]);
			}
			Console.Write(sb.ToString());
		}

	}
}


