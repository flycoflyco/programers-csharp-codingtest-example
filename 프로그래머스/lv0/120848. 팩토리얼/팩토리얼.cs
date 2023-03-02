using System;

public class Solution {
		public int solution(int n)
		{
			int answer = 0;

			for ( int i = 1; i <=10; i++)
			{
				int fac = GetFactorial(i);
				if ( n < fac)
				{
					return i - 1;
				}
				else if (n == fac)
				{
					return i;
				}
			}
			return answer;
		}

		public int GetFactorial(int n)
		{
			int result = 1;
			for (int i = 1; i <= n; i++)
			{
				result = result * i;
			}
			return result;
		}
	
}