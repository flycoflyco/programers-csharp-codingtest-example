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
			bool[] project = new bool[30];
			for ( int i = 0; i < project.Length; i++)
			{
				project[i] = false;
			}

			for (int i = 0; i < 28; i++)
			{
				string inputNumStr = Console.ReadLine();
				int inputNum = Convert.ToInt32(inputNumStr);
				project[inputNum - 1] = true;
			}

			for ( int i = 0; i < project.Length; i++)
			{
				if (!project[i])
					Console.WriteLine(i + 1);
			}
		}
	}
}
