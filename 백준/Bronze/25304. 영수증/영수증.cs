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
			string inputTotal = Console.ReadLine();
			int totalPrice = Convert.ToInt32(inputTotal);
			string numStr = Console.ReadLine();
			int num = Convert.ToInt32(numStr);

			int sum = 0;
			for ( int i = 0; i < num; i++)
			{
				string indexStr = Console.ReadLine();
				string[] indexSplit = indexStr.Split(' ');
				int indexPrice = Convert.ToInt32(indexSplit[0]);
				int indexCnt = Convert.ToInt32(indexSplit[1]);
				sum = sum + (indexPrice * indexCnt);
			}

			if (sum == totalPrice)
				Console.WriteLine("Yes");
			else
				Console.WriteLine("No");
		}
	}
}
