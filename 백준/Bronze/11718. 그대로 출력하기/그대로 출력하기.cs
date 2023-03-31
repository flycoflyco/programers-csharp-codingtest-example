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
			int a = 0;
			while(true)
			{
				string str = Console.ReadLine();
				if (str == "" || str == " " || a == 101)
					break;
				Console.WriteLine(str);
				a++;
			}

		}
	}
}

