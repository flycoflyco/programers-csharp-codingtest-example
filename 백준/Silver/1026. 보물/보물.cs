using System;
using System.Collections.Generic;

namespace ConsoleApp34
{
	public class Program
	{
		public static void Main()
		{
			string inputStr1 = Console.ReadLine();
			int n = Convert.ToInt32(inputStr1);

			string inputStr2 = Console.ReadLine();
			string[] inputSplit1 = inputStr2.Split(' ');
			List<int> aLst = new List<int>();
			for ( int i = 0; i < inputSplit1.Length; i++)
			{
				aLst.Add(Convert.ToInt32(inputSplit1[i]));
			}
			aLst.Sort();

			string inputStr3 = Console.ReadLine();
			string[] inputSplit2 = inputStr3.Split(' ');
			List<int> bLst = new List<int>();
			for (int i = 0; i < inputSplit2.Length; i++)
			{
				bLst.Add(Convert.ToInt32(inputSplit2[i]));
			}
			bLst.Sort();
			bLst.Reverse();

			int sum = 0;
			for ( int i = 0; i < n; i++)
			{
				sum += aLst[i] * bLst[i];
			}

			Console.WriteLine(sum);
		}

	}
}


