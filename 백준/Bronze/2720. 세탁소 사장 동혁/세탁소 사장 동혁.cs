using System;
using System.Collections.Generic;


namespace ConsoleApp34
{
	public class Program
	{
		public static void Main()
		{
			
			string inputStr = Console.ReadLine();
			int input = Convert.ToInt32(inputStr);
			int[,] arr = new int[input, 4];
			
			int qCnt = 0;
			int dCnt = 0;
			int nCnt = 0;
			int pCnt = 0;

			for ( int i = 0; i < input; i++)
			{
				string lineNumStr = Console.ReadLine();
				int num = Convert.ToInt32(lineNumStr);
				int margin = num;

				qCnt = 0;
				dCnt = 0;
				nCnt = 0;
				pCnt = 0;

				while (margin != 0)
				{
					if (margin >= 25)
					{
						qCnt++;
						margin = margin - 25;
					}
					else if (margin >= 10)
					{
						dCnt++;
						margin = margin - 10;
					}
					else if (margin >= 5)
					{
						nCnt++;
						margin = margin - 5;
					}
					else
					{
						pCnt++;
						margin = margin - 1;
					}
						
				}
				arr[i, 0] = qCnt;
				arr[i, 1] = dCnt;
				arr[i, 2] = nCnt;
				arr[i, 3] = pCnt;
			}
			for ( int i = 0; i < input; i++)
			{
				for (int j = 0; j < 4; j++)
				{
					Console.Write(arr[i, j]);
					if ( j != 3)
						Console.Write(" ");
				}
				Console.WriteLine();
			}
		}



	}
}

