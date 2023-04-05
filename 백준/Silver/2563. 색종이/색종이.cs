using System;
using System.Collections.Generic;

namespace ConsoleApp34
{
	public class Program
	{
		public static void Main()
		{
			int[,] background = new int[100,100];
			int result = 0;
			for ( int i = 0; i < 100; i++)
			{
				for ( int j = 0; j < 100; j++)
				{
					background[i, j] = 0;
				}
			}
			// 색종이 개수
			string inputNumStr = Console.ReadLine();
			int inputNum = Convert.ToInt32(inputNumStr);

			for ( int i = 0; i < inputNum;i++)
			{
				string cmdLine = Console.ReadLine();
				string[] cmdSplit = cmdLine.Split(' ');
				int x = Convert.ToInt32(cmdSplit[0]);
				int y = Convert.ToInt32(cmdSplit[1]);
				for ( int j = x; j < (x + 10); j++)
				{
					for ( int k = y; k < (y+10); k++)
					{
						background[j, k]++;
					}
				}
			}
			int a = 0;

			for (int i = 0; i < 100; i++)
			{
				for (int j = 0; j < 100; j++)
				{
					if (background[i, j] > 0)
						result++;

				}
			}

			Console.WriteLine(result);

			int b = 0;
		}
	}
}

