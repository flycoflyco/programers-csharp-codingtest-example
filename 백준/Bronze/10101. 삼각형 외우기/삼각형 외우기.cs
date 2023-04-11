using System;

namespace ConsoleApp34
{
	public class Program
	{
		public static void Main()
		{
			string result = string.Empty;
			int[] arr = new int[3];
			for ( int i = 0; i < 3; i++)
			{
				string inputStr = Console.ReadLine();
				int input = Convert.ToInt32(inputStr);
				arr[i] = input;
			}

			int sum = arr[0] + arr[1] + arr[2];
			if (arr[0] == 60 && arr[0] == arr[1]  && arr[1] == arr[2])
				result = "Equilateral";
			else if ( sum == 180 && (arr[0] == arr[1] || arr[0] == arr[2] || arr[1] == arr[2]))
				result = "Isosceles";
			else if ( sum == 180 && (arr[0] != arr[1] && arr[1] != arr[2] && arr[0] != arr[2]))
				result = "Scalene";
			else if ( sum != 180)
				result = "Error";

			Console.WriteLine(result);


		}
	}
}

