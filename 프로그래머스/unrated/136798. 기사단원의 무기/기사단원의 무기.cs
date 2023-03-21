using System;

public class Solution {
		public int solution(int number, int limit, int power)
		{
			int answer = 0;

			for ( int i = 1;  i <= number; i++)
			{
				int tempPower = GetYaksuCnt(i);
				if (tempPower > limit)
				{
					tempPower = power;
				}
				answer += tempPower;
			}
			return answer;
		}

		public int GetYaksuCnt ( int num)
		{
			int result = 0;
			int i = 0;
			for (i =1; i*i < num; i++)
				if ( num % i == 0)
					result+=2;

			if (i * i == num)
				result++;


			return result;
		}
}