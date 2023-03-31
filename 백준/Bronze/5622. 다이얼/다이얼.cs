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
			string grandMaStr = Console.ReadLine();

			// index == 0;, time == 3
			string[] dial = new string[] { "ABC", "DEF", "GHI", "JKL", "MNO", "PQRS", "TUV", "WXYZ" };
			int totalTime = 0;
			
			for (int i = 0; i < grandMaStr.Length; i++)
			{
				char ch = grandMaStr[i];
				for (int j = 0; j < dial.Length; j++)
				{
					if (dial[j].Contains(ch))
					{
						totalTime += j + 3;
						break;
					}
				}
			}
			Console.WriteLine(totalTime);

		}
	}
}

