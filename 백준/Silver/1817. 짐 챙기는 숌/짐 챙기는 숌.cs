using System;
using System.Collections.Generic;

namespace ConsoleApp34
{
	public class Program
	{
		public static void Main()
		{
			string inputStr = Console.ReadLine();
			string[] inputStrSplit = inputStr.Split(' ');
			int n = Convert.ToInt32(inputStrSplit[0]);
			int m = Convert.ToInt32(inputStrSplit[1]);

			if (n == 0)
			{
				Console.WriteLine(0);
				return;
			}
				

			int[] bookArr = new int[n];

			string bookWeightStrCmd = Console.ReadLine();
			string[] bookWeightStrCmdSplit = bookWeightStrCmd.Split(' ');



			for (int i = 0; i < bookWeightStrCmdSplit.Length; i++)
			{
				bookArr[i] = Convert.ToInt32(bookWeightStrCmdSplit[i]);
			}

			int boxSize = m;
			int boxCnt = 1;
			for (int i = 0; i < bookArr.Length; i++)
			{
				if ( boxSize >= bookArr[i])
				{
					boxSize = boxSize - bookArr[i];
				}
				else
				{
					boxCnt++;
					boxSize = m;
					boxSize = boxSize - bookArr[i];
				}
			}

			Console.WriteLine(boxCnt);

			// int a = 0;
		}

	}
}