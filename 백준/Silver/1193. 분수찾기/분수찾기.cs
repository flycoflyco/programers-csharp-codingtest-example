using System;

namespace ConsoleApp34
{
	public class Program
	{
		public static void Main()
		{
			string inputStr = Console.ReadLine();
			int input = Convert.ToInt32(inputStr);

			int n = 1;
			int sum = 0;
			while (true)
			{
				sum = sum + n;
				if (sum >= input)
				{
					sum = sum - n;
					break;
				}
					
				n++;
			}

			int row = 0;
			int col = 0;
				

			for (int i = 1; i <= n; i++)
			{
				if ( sum + i == input)
				{
					row = i;
					col = n - i + 1;
					break;
				}
			}

			if (n % 2 != 0)
			{
				int temp = row;
				row = col;
				col = temp;
			}

			Console.WriteLine(row.ToString()+ "/"+ col.ToString());
		}
	}
}

