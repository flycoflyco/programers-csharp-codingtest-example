using System;
using System.Collections.Generic;

namespace ConsoleApp34
{
	public class Program
	{
		public static void Main()
		{
			string inputStr1 = Console.ReadLine();
			string[] inputSplit = inputStr1.Split(' ');

			int minNum1 = Convert.ToInt32(GetMinMaxString(inputSplit[0], false));
			int minNum2 = Convert.ToInt32(GetMinMaxString(inputSplit[1], false));

			int maxNum1 = Convert.ToInt32(GetMinMaxString(inputSplit[0], true));
			int maxNum2 = Convert.ToInt32(GetMinMaxString(inputSplit[1], true));


			Console.Write(minNum1 + minNum2);
			Console.Write(" ");
			Console.Write(maxNum1 + maxNum2);
		}

		public static string GetMinMaxString(string numStr, bool isMax)
		{
			string result = string.Empty;
			List<char> chLst = new List<char>();
			for (int i = 0; i < numStr.Length; i++)
			{
				char ch = numStr[i];
				if (!isMax && ch == '6')
				{
					ch = '5';
				}
				else if (isMax && ch == '5')
				{
					ch = '6';
				}
				chLst.Add(ch);
			}
			result = new string(chLst.ToArray());

			return result;
		}
	}
}

