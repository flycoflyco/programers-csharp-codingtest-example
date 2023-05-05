using System;

namespace ConsoleApp34
{
	public class Program
	{
		public static void Main()
		{
			string inputStr1 = Console.ReadLine();
			int input = Convert.ToInt32(inputStr1);

			int[] arr = new int[input];
			for (int i = 0; i < input; i++)
			{
				string numStr= Console.ReadLine();
				arr[i] = Convert.ToInt32(numStr);
			}

			for ( int i = 0; i < arr.Length-1; i++)
			{
				for (int j = 0; j < arr.Length - 1 - i; j++)
				{
					if ( arr[j] > arr[j+1])
					{
						int temp = arr[j];
						arr[j] = arr[j+1];
						arr[j+1] = temp;
					}

				}
			}
			for ( int i = 0; i < arr.Length; i++)
			{
				Console.WriteLine(arr[i]);
			}
			
		}
	}
}

