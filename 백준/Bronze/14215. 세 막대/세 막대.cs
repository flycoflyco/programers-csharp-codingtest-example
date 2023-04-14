using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp34
{
	public class Program
	{
		public static void Main()
		{
			string inputStr = Console.ReadLine();
			string[] inputSplit = inputStr.Split(' ');
			int[] arr = new int[] { Convert.ToInt32(inputSplit[0]), Convert.ToInt32(inputSplit[1]), Convert.ToInt32(inputSplit[2]) };

			int result = CheckTriangle(arr);
			string answer = string.Empty;

			if (result == 0)
				answer = (arr[0] + arr[1] + arr[2]-1).ToString();
			else if ( result >= 1)
				answer = (arr[0] + arr[1] + arr[2] - result - 1).ToString();
			else
				answer = (arr[0] + arr[1] + arr[2]).ToString();

			Console.WriteLine(answer);


		}
		public static int CheckTriangle(int[] arr)
		{
			int result = 0;
			List<int> lstInt = new List<int>(arr);
			int max = lstInt.Max();
			lstInt.Remove(max);
			result = max - (lstInt[0] + lstInt[1]);
			return result;
		}
	}
}

