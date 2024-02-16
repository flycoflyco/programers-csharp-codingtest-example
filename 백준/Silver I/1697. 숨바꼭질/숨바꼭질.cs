using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp6
{
	class Program
	{
		public static void Main(string[] args)
		{
			string inputStr = Console.ReadLine();
			string[] splitStrs = inputStr.Split(' ');

			int startNode = int.Parse(splitStrs[0]);
			int dest = int.Parse(splitStrs[1]);

			if (startNode == dest)
			{
				Console.WriteLine(0);
				return;
			}

			bool[] checkNum = Enumerable.Repeat(true, 100001).ToArray();
			int[] secondArr = Enumerable.Repeat(0, 100001).ToArray();

			Queue<int> qu = new Queue<int>();
			qu.Enqueue(startNode);
			secondArr[startNode] = 0;
			int result = 0;
			while (qu.Count != 0)
			{
				int currNode = qu.Dequeue();
				if (currNode == dest)
				{
					result = secondArr[currNode] + 1;
					break;
				}
				else
				{
					checkNum[currNode] = false;
					int[] arr = new int[3] { currNode * 2, currNode + 1, currNode - 1 };
					bool flag = false;
					for (int i = 0; i < arr.Length; i++)
					{
						int moveNum = arr[i];
						if (0 <= moveNum && moveNum <= 100000 && checkNum[moveNum])
						{
							if (moveNum == dest)
							{
								result = secondArr[currNode]+1;
								flag = true;
								break;
							}
							else
							{
								checkNum[moveNum] = false;
								secondArr[moveNum] = secondArr[currNode] + 1;
								qu.Enqueue(moveNum);
							}
						}
					}
					if (flag)
						break;
				}
			}
			Console.WriteLine(result);
		}
	}
}