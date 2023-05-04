using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp34
{
	public class Program
	{
		public static void Main()
		{
			string inputStr = Console.ReadLine();
			string[] inputSplit = inputStr.Split(' ');
			int n = Convert.ToInt32(inputSplit[0]);
			int m = Convert.ToInt32(inputSplit[1]);

			List<int> packagePrice = new List<int>();
			List<int> piecePrice = new List<int>();

			for ( int i = 0; i < m; i++)
			{
				string cmdLine = Console.ReadLine();
				string[] cmdSplit = cmdLine.Split(' ');
				packagePrice.Add(Convert.ToInt32(cmdSplit[0]));
				piecePrice.Add(Convert.ToInt32(cmdSplit[1]));
			}

			int setMin = packagePrice.Min();
			int pieceMin = piecePrice.Min();
			int resultPrice = 0;
			if ( setMin > (pieceMin*6))
			{
				resultPrice = n * pieceMin;
			}
			else
			{
				int mok = n / 6;
				int margin = n % 6;
				if (setMin < (margin * pieceMin))
					resultPrice = (mok + 1) * setMin;
				else
					resultPrice = (mok * setMin) + (margin * pieceMin);
			}


			Console.WriteLine(resultPrice);


		}

	}
}


