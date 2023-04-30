using System;

namespace ConsoleApp34
{
	public class Program
	{
		public static void Main()
		{
			int[] arr = { 500, 100, 50, 10, 5, 1 };
			string inputStr1 = Console.ReadLine();
			int input = Convert.ToInt32(inputStr1);

			int margin = 1000 - input;

			int index = 0;
			int mok = 0;
			int totalCnt = 0;
			while ( margin > 0)
			{
				if (margin >= arr[index])
				{
					mok = margin / arr[index];
					margin = margin % arr[index];
					
					totalCnt += mok; 
				}
				index++;
			}
			Console.WriteLine(totalCnt);
		}
	}
}

