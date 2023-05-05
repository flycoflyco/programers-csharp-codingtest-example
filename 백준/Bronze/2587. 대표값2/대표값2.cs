using System;

namespace ConsoleApp34
{
	public class Program
	{
		public static void Main()
		{
			int sum = 0;
			int[] arr = new int[5];
			for (int i = 0; i < 5; i++)
			{
				string str = Console.ReadLine();
				int num = Convert.ToInt32(str);
				arr[i] = num;
				sum += num;
			}

			for ( int i = 0; i < arr.Length; i++)
			{
				for ( int j =0; j < arr.Length-1-i; j++)
				{
					if ( arr[j] > arr[j+1] )
					{
						int temp = arr[j];
						arr[j] = arr[j+1];
						arr[j+1] = temp;
					}
				}
			}

			Console.WriteLine(sum/5);
			Console.WriteLine(arr[2]);




		}
	}
}

