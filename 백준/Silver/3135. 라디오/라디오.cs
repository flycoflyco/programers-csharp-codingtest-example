using System;
using System.Collections.Generic;

namespace ConsoleApp34
{
	public class Program
	{
		public static void Main()
		{

			int result = 0;
			string inputStr = Console.ReadLine();
			string[] inputSplit = inputStr.Split(' ');
			int curr = Convert.ToInt32(inputSplit[0]);
			int dest = Convert.ToInt32(inputSplit[1]);

			string inputCmdStr = Console.ReadLine();
			int cmdNum = Convert.ToInt32(inputCmdStr);
			int[] arr = new int[cmdNum];
			int gap = int.MaxValue;
			int gapIndex = -1;
			// List<int> favLst = new List<int>();
			for ( int i = 0; i < cmdNum; i++)
			{
				string cmdStr = Console.ReadLine();
				arr[i] = Convert.ToInt32(cmdStr);
				
				if (Math.Abs(dest - arr[i]) < gap)
				{
					gap = Math.Abs(dest - arr[i]);
					gapIndex = i;
				}
				// favLst.Add(Convert.ToInt32(cmdStr));
			}

			if (Math.Abs(curr - dest) <= gap)
			{
				// 즐겨찾기 필요 없는 경우
				result = Math.Abs(curr - dest);
			}
			else
			{
				// 즐겨찾기 필요한 경우
				result++; // 즐겨찾기 버튼 눌렀을때
				result += gap;
			}

			Console.WriteLine(result);

		}
	}
}

