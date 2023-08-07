using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
	class Program
	{
		public static void Main(string[] args)
		{
			string testCaseNumStr = Console.ReadLine();
			int testCaseNum = Convert.ToInt32(testCaseNumStr);
			List<int> answer = new List<int>();

			for (int i = 0; i < testCaseNum; i++)
			{
				string floorStr = Console.ReadLine();
				string roomNumStr = Console.ReadLine();
				int floor = Convert.ToInt32(floorStr);
				int roomNum = Convert.ToInt32(roomNumStr);
				int[] currArr = new int[roomNum];
				int[] prevArr = new int[roomNum];
				for (int j = 0; j <= floor; j++)
				{
					// 첫번째 층의 경우 1,2,3,4...RoomNum 까지
					if (j == 0)
					{
						for (int k = 0; k < roomNum; k++)
						{
							prevArr[k] = k + 1;
						}
						continue;
					}
					currArr = new int[roomNum];
					for (int k = 0; k < roomNum; k++)
					{
						int subSum = 0;
						for (int l = 0; l <= k; l++)
						{
							subSum += prevArr[l];
						}
						currArr[k] = subSum;
					}
					prevArr = currArr;
				}
				answer.Add(currArr[currArr.Length - 1]);
			}

			for (int i = 0; i < answer.Count; i++)
			{
				Console.WriteLine(answer[i]);
			}
		}
	}
}