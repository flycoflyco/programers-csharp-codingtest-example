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
		//연속된 세 개의 정수를 더해 12가 되는 경우는 3, 4, 5입니다.두 정수 num과 total이 주어집니다.
		//연속된 수 num개를 더한 값이 total이 될 때, 정수 배열을 오름차순으로 담아 return하도록 solution함수를 완성해보세요.

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
			int[] answer = new int[num]; // 연속된 수의 배열
			// 등차수열로 계산
			int startNum = (total - ((num - 1) * (1 + (num - 1))) / 2) / num; // 연속된 수의 시작할 숫자
			for (int i = 0; i < answer.Length; i++)
			{
				answer[i] = startNum + i;
			}
			return answer;
		}
	}
}
