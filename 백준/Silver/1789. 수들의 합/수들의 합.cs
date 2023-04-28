using System;
using System.Collections.Generic;

namespace ConsoleApp34
{
	public class Program
	{
		public static void Main()
		{
			string inputStr1 = Console.ReadLine();
			long s = Convert.ToInt64(inputStr1);

			long i = 1;
			for ( i = 1; i <= s; i++)
			{
				s = s - i;
				if (s < 0)
					break;
			}

			Console.WriteLine(i-1);
		}

	}
}


