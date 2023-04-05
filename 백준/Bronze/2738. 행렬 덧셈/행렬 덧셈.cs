using System;


namespace ConsoleApp34
{
	public class Program
	{
		public static void Main()
		{
			string nmStr = Console.ReadLine();
			string[] nmSplit = nmStr.Split(' ');
			int n = Convert.ToInt32(nmSplit[0]);
			int m = Convert.ToInt32(nmSplit[1]);

			int[,] arr1 = new int[n, m];
			int[,] arr2 = new int[n, m];

			for ( int i = 0; i < n*2; i++)
			{
				string lineInput = Console.ReadLine();
				string[] lineSplit = lineInput.Split(' ');
				if (i < n)
				{
					for ( int j = 0; j < lineSplit.Length; j++)
					{
						arr1[i, j] = Convert.ToInt32(lineSplit[j]);
					}
				}
				else
				{
					for (int j = 0; j < lineSplit.Length; j++)
					{
						arr2[i-n, j] = Convert.ToInt32(lineSplit[j]);
					}
				}
			}

			for ( int i = 0; i < n; i++)
			{
				for ( int j = 0; j < m; j++)
				{
					Console.Write(arr1[i, j] + arr2[i, j]);
					if ( j != m-1)
						Console.Write(' ');
				}
				Console.WriteLine();
			}
		}
	}
}

