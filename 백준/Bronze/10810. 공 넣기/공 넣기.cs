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
			string nmStr = Console.ReadLine();
			string[] nmArr = nmStr.Split(' ');
			int n = Convert.ToInt32(nmArr[0]);
			int m = Convert.ToInt32(nmArr[1]);

			int[] numArr = new int[n];

			for (int i = 0; i < m; i++)
			{
				string cmd = Console.ReadLine();
				string[] ijk = cmd.Split(' ');
				int startindex = Convert.ToInt32(ijk[0]);
				int endindex = Convert.ToInt32(ijk[1]);
				int ballNum = Convert.ToInt32(ijk[2]);

				for ( int j = startindex-1; j <= endindex - 1;j++)
				{
					numArr[j] = ballNum;
				}
			}

			int a = 0;

			for (int i = 0; i < numArr.Length; i++)
			{
				Console.Write(numArr[i]);
				if ( i != numArr.Length-1)
					Console.Write(' ');
			}

		}
	}
}
