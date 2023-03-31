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
			string[] nmStrSplit = nmStr.Split(' ');
			int boxNum = Convert.ToInt32(nmStrSplit[0]);
			int cmdNum = Convert.ToInt32(nmStrSplit[1]);
			int[] arr = new int[boxNum];
			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = i + 1;
			}

			for (int i = 0; i < cmdNum; i++)
			{
				string ijkStr = Console.ReadLine();
				string[] ijk = ijkStr.Split(' ');
				int begin = Convert.ToInt32(ijk[0]);
				int mid = Convert.ToInt32(ijk[2]);
				int end = Convert.ToInt32(ijk[1]);
				for (int j = 0; j < mid - begin; j++)
				{

					for ( int k = begin-1; k < end-1;k++)
					{
						int temp = arr[k];
						arr[k] = arr[k + 1];
						arr[k + 1] = temp;
					}
				}
			}

			for ( int i = 0; i < arr.Length; i++)
			{
				Console.Write(arr[i]);
				if ( i != arr.Length -1)
					Console.Write(" ");
			}
			
		}
	}
}

