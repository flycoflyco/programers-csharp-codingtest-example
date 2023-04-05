using System;
using System.Collections.Generic;


namespace ConsoleApp34
{
	public class Program
	{
		public static void Main()
		{
			string result = string.Empty;
			string inputStr = Console.ReadLine();
			string[] inputSplit = inputStr.Split(' ');

			int inputNum = Convert.ToInt32(inputSplit[0]);
			
			string inputBaseStr = inputSplit[1];
			int inputBase = Convert.ToInt32(inputBaseStr);

			List<char> arr = new List<char>();

			int mok = inputNum;
			int margin = 0;
			while ( mok != 0)
			{
				margin = mok % inputBase;
				char ch = GetChar(margin);
				arr.Add(ch);
				mok = mok / inputBase;
			}

			arr.Reverse();
			result = new string(arr.ToArray());
			Console.WriteLine(result);
		}

		public static char GetChar (int num)
		{
			char result;
			if (num > 9)
				result = Convert.ToChar(num + 55);
			else
				result = Convert.ToChar(num.ToString());
			return result;
		}

	}
}

