using System;
using System.Collections.Generic;

namespace ConsoleApp34
{
	public class Program
	{
		public static void Main()
		{
			char[,] chArray = new char[5,15];

			for ( int i = 0; i < 5; i++)
			{
				for ( int j = 0; j < 15; j++)
				{
					chArray[i, j] = '@';
				}
			}

			for (int i = 0; i < 5; i++)
			{
				string lineInput = Console.ReadLine();
				for (int j = 0; j < lineInput.Length; j++)
				{
					chArray[i, j] = lineInput[j];
				}
			}

			for (int i = 0; i < 15; i++)
			{
				for (int j = 0; j < 5; j++)
				{
					if (chArray[j, i] != '@')
						Console.Write(chArray[j, i]);
				}
			}
		}
	}
}

