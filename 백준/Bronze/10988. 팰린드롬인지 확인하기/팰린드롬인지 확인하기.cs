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
			string inputSen = Console.ReadLine();
			bool flag = true;
			for (int i = 0; i < inputSen.Length/2; i++)
			{
				if ( inputSen[i] != inputSen[inputSen.Length-1-i])
				{
					flag = false;
					break;
				}
			}
			if (flag)
				Console.WriteLine(1);
			else
				Console.WriteLine(0);

		}
	}
}

