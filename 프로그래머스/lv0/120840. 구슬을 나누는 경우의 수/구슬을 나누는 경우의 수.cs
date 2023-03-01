using System;

public class Solution {
		public int solution(int balls, int share)
		{
			int answer = 0;
			double tempLong = 0;
			double dBalls = (double)balls;
			double dShare = (double)share;
			double firstLong = factorial(dBalls);
			double secondLong = factorial(dBalls - dShare) * factorial(dShare);
			tempLong = firstLong / secondLong;

			

			answer = (int)Math.Round(tempLong, 4); 
			return answer;
		}

		public double factorial(double num)
		{
			double result = 1;

			for (double i = 1; i <= num; i++)
			{
				result = result * i;
			}
			return result;
		}
}