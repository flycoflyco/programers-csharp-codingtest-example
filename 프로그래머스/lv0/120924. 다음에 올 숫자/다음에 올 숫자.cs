using System;

public class Solution
{
	public int solution(int[] common)
	{
		int answer = 0;

		int length = common.Length;

		int sum1 = common[length - 1] - common[length - 2];
		int sum2 = common[length - 2] - common[length - 3];

		if ( sum1 == sum2)
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