using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programers_CSharp_Codingtest_Example
{
	public class SumOfConsecutiveNumbers
	{
		// 연속된 수의 합 문제
		//static void Main(string[] args)
		//{
		//	int[] answer1 = solution(3, 12);
		//	int[] answer2 = solution(5, 15);
		//	int[] answer3 = solution(4, 14);
		//	int[] answer4 = solution(5, 5);
		//	int a = 0;
		//}
		public int[] solution(int num, int total)
		{
			int[] answer = new int[num];
			int startNum = (total - ((num - 1) * (1 + (num - 1))) / 2) / num;
			for (int i = 0; i < answer.Length; i++)
			{
				answer[i] = startNum + i;
			}
			return answer;
		}
	}
}
