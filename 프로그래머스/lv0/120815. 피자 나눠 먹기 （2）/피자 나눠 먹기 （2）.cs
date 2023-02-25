using System;

public class Solution {
		public int solution(int n)
		{
			int answer = 1;

			int piece = 6;
			int lcmNum = LCM(piece, n);
			int pizzaNum = lcmNum / piece;

			//while(n > (pizzaNum * piece))
			//{
			//	pizzaNum++;
			//}

			answer = pizzaNum;

			return answer;
		}
		public int LCM(int num1, int num2)
		{
			int lcm = (num1 > num2) ? num1 : num2;
			while (true)
			{
				if (lcm % num1 == 0 && lcm % num2 == 0)
				{
					break;
				}
				lcm++;
			}
			return lcm;
		}
}