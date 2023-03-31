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
			int[] arr = new int[6] { 1, 1, 2, 2, 2, 8 };
			int[] answer = new int[6] { 0, 0, 0, 0, 0, 0 };
			string inputStr = Console.ReadLine();
			string[] inputStrSplit = inputStr.Split(' ');
			for ( int i = 0; i < inputStrSplit.Length; i++)
			{
				string inputNumStr = inputStrSplit[i];
				int inputNum = Convert.ToInt32(inputNumStr);
				answer[i] = arr[i] - inputNum;
			}

			for ( int i =0; i < answer.Length; i++)
			{
				Console.Write(answer[i]);
				if (i != answer.Length-1)
					Console.Write(" ");
			}
			
		}
	}
}

