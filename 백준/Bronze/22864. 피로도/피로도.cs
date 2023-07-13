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
			int a = Convert.ToInt32(inputStrSplit[0]);
			int b = Convert.ToInt32(inputStrSplit[1]);
			int c = Convert.ToInt32(inputStrSplit[2]);
			int m = Convert.ToInt32(inputStrSplit[3]);

			int fati = m;
			int totalProc = 0;

			for ( int i = 0; i < 24; i++)
			{
				if (fati >= a)
				{
					fati -= a;
					totalProc += b;
				}
				else
				{
					fati += c;
					if (fati > m) // 음수처리
						fati = m;
				}
			}

			Console.WriteLine(totalProc);
		}

	}
}