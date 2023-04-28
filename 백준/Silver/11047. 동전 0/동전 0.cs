using System;
using System.Collections.Generic;

namespace ConsoleApp34
{
	public class Program
	{
		public static void Main()
		{
			string inputStr = Console.ReadLine();
			string[] inputSplit = inputStr.Split(' ');
			int n = Convert.ToInt32(inputSplit[0]);
			int k = Convert.ToInt32(inputSplit[1]);
			List<int> coins = new List<int>();
			for ( int i = 0; i < n; i++)
			{
				string readLine = Console.ReadLine();
				int coin = Convert.ToInt32(readLine);
				coins.Add(coin);
			}

			coins.Reverse();

			int margin = k;
			int mok = 0;
			int mokSum = 0;

			for ( int i = 0; i < coins.Count; i++)
			{
				int coin = coins[i];
				if (margin >= coin)
				{
					mok = margin / coin;
					margin = margin % coin;
					mokSum += mok;

					if (margin == 0)
						break;
				}
			}

			Console.WriteLine(mokSum);
		}

	}
}


