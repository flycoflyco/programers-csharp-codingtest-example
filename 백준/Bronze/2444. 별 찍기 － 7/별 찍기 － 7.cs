using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp34
{
	public class Program
	{
		public static void Main()
		{
			string inputStr = Console.ReadLine();
			int input = Convert.ToInt32(inputStr);

			int spaceNum = input-1;
			int starNum = 1;
			int starNumCnt = (2 * starNum) - 1;
			for (int i = 0; i < input; i++)
			{
				for (int j = 0; j < spaceNum; j++)
				{
					Console.Write(" ");
				}
				for ( int j = 0; j < starNumCnt; j++)
				{
					Console.Write("*");
				}
				spaceNum--;
				starNum++;
				starNumCnt = (2 * starNum) - 1;
				Console.WriteLine();
			}

			spaceNum++;
			spaceNum++;
			starNum--;
			starNum--;
			starNumCnt = (2 * starNum) - 1;

			for (int i = 0; i < input-1; i++)
			{
				for (int j = 0; j < spaceNum; j++)
				{
					Console.Write(" ");
				}
				for (int j = 0; j < starNumCnt; j++)
				{
					Console.Write("*");
				}
				spaceNum++;
				starNum--;
				starNumCnt = (2 * starNum) - 1;
				Console.WriteLine();
			}


			int a = 0;
			
		}
	}
}

