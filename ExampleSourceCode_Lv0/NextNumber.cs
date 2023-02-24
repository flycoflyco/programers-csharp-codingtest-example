using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programers_CSharp_Codingtest_Example.ExampleSourceCode_Lv0
{
	public class NextNumber
	{
		// 등차수열 혹은 등비수열 common이 매개변수로 주어질 때, 마지막 원소 다음으로 올 숫자를 return 하도록 solution 함수를 완성해보세요.

		public int solution(int[] common)
		{
			int answer = 0;

			int length = common.Length;

			int sum1 = common[length - 1] - common[length - 2];
			int sum2 = common[length - 2] - common[length - 3];

			if (sum1 == sum2)
			{
				// 등차 수열
				answer = common[length - 1] + sum1;

			}
			else
			{
				// 등비 수열
				int gap1 = common[length - 1] / common[length - 2];
				int gap2 = common[length - 1] / common[length - 2];
				if (gap1 == gap2)
				{
					answer = common[length - 1] * gap1;
				}
				else
				{
					answer = 0;
				}
			}

			return answer;
		}
	}
}
