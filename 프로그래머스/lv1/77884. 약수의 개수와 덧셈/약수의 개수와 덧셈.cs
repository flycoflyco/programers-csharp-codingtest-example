using System;

public class Solution {
		public int solution(int left, int right)
		{
			int answer = 0;

			for ( int i = left; i <= right; i++ )
			{
				if (GetYaksu(i) % 2 == 0)
					answer += i;
				else
					answer -= i;
			}
			return answer;
		}

		public int GetYaksu(int num)
		{
			int result = 0;
			for ( int i = 1; i <= num; i++)
			{
				if (num % i == 0)
					result++;
			}
			return result;
		}
}