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

			int[] boxArr = new int[boxNum];

			for ( int i = 0; i < boxArr.Length; i++)
			{
				boxArr[i] = i + 1;
			}

			for ( int i = 0; i < cmdNum; i++)
			{
				string indexCmdStr = Console.ReadLine();
				string[] indexCmdSplit = indexCmdStr.Split(' ');
				int start = Convert.ToInt32(indexCmdSplit[0]);
				start--;
				int end = Convert.ToInt32(indexCmdSplit[1]);
				end--;

				for (int j = 0; j < end - start; j++)
				{
					if (start + j == end - j)
						break;

					int temp = boxArr[start + j];
					boxArr[start + j] = boxArr[end - j];
					boxArr[end - j] = temp;

					if ( (end - j) - (start+j) == 1)
						break;
				}
				
			}

			int a = 0;


			for ( int i = 0; i <boxArr.Length; i++)
			{
				Console.Write(boxArr[i]);
				if ( i != boxArr.Length-1)
					Console.Write(" ");
			}



		}
	}
}
