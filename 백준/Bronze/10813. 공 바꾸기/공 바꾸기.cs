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

			for (int i = 0; i < numArr.Length; i++)
			{
				numArr[i] = i + 1;
			}

			for (int i = 0; i < m; i++)
			{
				string cmd = Console.ReadLine();
				string[] ij = cmd.Split(' ');
				int sw1 = Convert.ToInt32(ij[0]);
				sw1--;
				int sw2 = Convert.ToInt32(ij[1]);
				sw2--;

				int temp = numArr[sw1];
				numArr[sw1] = numArr[sw2];
				numArr[sw2] = temp;
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
