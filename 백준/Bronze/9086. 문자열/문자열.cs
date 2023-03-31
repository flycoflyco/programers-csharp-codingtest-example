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
			string cmdNumStr = Console.ReadLine();
			int cmdNum = Convert.ToInt32(cmdNumStr);
			string[] result = new string[cmdNum];

			for ( int i = 0; i < cmdNum; i++)
			{
				string indexStr = Console.ReadLine();
				string tempStr = string.Empty;
				tempStr += indexStr[0];
				tempStr += indexStr[indexStr.Length-1];
				result[i] = tempStr;
			}

			for (int i = 0; i < cmdNum; i++)
			{
				Console.WriteLine(result[i]);
			}
		}
	}
}

