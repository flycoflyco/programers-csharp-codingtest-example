using System;

public class Solution {
		public int solution(int num1, int num2)
		{
			int answer = 0;
			double mok = (double)num1 / (double)num2;
			double mok2 = mok * 1000;
			answer = (int)mok2;
			return answer;
		}
}