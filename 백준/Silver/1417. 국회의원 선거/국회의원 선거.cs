using System;
using System.Collections.Generic;

namespace ConsoleApp34
{
	public class Program
	{
		public static void Main()
		{
			string inputStr = Console.ReadLine();
			int inputNum = Convert.ToInt32(inputStr);

			int dasom = 0;

			List<int> arrLst = new List<int>();
			for (int i = 0; i < inputNum; i++)
			{
				string numStr = Console.ReadLine();
				int num = Convert.ToInt32(numStr);
				if (i == 0)
				{
					dasom = num;
					continue;
				}

				if (num >= dasom)
				{
					arrLst.Add(num);
				}
			}

			// 다솜이를 제외한 개수가 없다면 0
			if (arrLst.Count == 0)
			{
				Console.WriteLine("0");
				return;
			}

			int result = 0;

			arrLst.Sort();
			arrLst.Reverse();

			int index = 0;
			while (true)
			{
				int maxindex = GetMaxVotes(arrLst.ToArray());
				if (dasom <= arrLst[maxindex])
				{
					dasom++;
					arrLst[maxindex]--;
					result++;
				}
				else if (dasom > arrLst[maxindex])
				{
					break;
				}

				index++;

				if (index >= arrLst.Count)
				{
					index = 0;
				}
			}
			Console.WriteLine(result);

		}

		// 배열에서 가장 큰 값을 찾아 인덱스를 반환하는 함수
		public static int GetMaxVotes(int[] votes)
		{
			int max = votes[0];
			int maxVotesIndex = 0;

			for (int i = 1; i < votes.Length; i++)
			{
				if (votes[i] > max)
				{
					max = votes[i];
					maxVotesIndex = i;
				}
			}

			return maxVotesIndex;
		}


	}
}