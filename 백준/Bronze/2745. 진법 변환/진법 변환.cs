using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp34
{
	public class Program
	{
		public static void Main()
		{
			int result = 0;
			string inputStr = Console.ReadLine();
			string[] inputSplit = inputStr.Split(' ');

			string inputNum = inputSplit[0];
			inputNum = new string(inputNum.Reverse().ToArray());
			string inputBaseStr = inputSplit[1];
			int inputBase = Convert.ToInt32(inputBaseStr);

			for (int i = 0; i < inputNum.Length; i++)
			{
				char ch = inputNum[i];
				int num = GetNumber(ch);
				int baseNum = GetPow(inputBase, i);
				result += num * baseNum;
			}

			Console.WriteLine(result);
			
		}

		public static int GetPow(int num, int powNum)
		{
			int result = num;
			if (powNum == 0)
				return 1;
			for (int i = 1; i < powNum; i++)
			{
				result = result * num;
			}
			return result;
		}

		public static int GetNumber(char ch)
		{
			int result = 0;
			if (47 < ch && ch < 58)
			{
				// 숫자인 경우
				result = Convert.ToInt32(ch.ToString());
			}
			else if (64 < ch && ch < 91)
			{
				// 알파벳일 경우
				result = Convert.ToInt32((ch - 55).ToString());
			}
			return result;
		}
	}
}

