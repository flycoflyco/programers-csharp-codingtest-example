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
			string result = string.Empty;
			string inputByteStr = Console.ReadLine();
			int inputByte = Convert.ToInt32(inputByteStr);

			int num = inputByte / 4;

			for ( int i = 0; i < num; i++)
			{
				result += "long ";
			}

			result += "int";

			Console.WriteLine(result);
			
		}
	}
}
