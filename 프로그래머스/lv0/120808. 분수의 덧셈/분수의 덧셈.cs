using System;

public class Solution {
		public int[] solution(int numer1, int denom1, int numer2, int denom2)
		{
			//최소공배수를 통해 분수 덧셈
			int[] answer = new int[2];
			int lcm = LCM(denom1, denom2);
			int mok1 = lcm / denom1;
			int mok2 = lcm / denom2;

			int nNumer1 = mok1 * numer1;
			int nNumer2 = mok2 * numer2;

			int sumNumer = nNumer1 + nNumer2;

			// 최대공약수
			int gcm = GCD(sumNumer, lcm);

			// 최대공약수를 통해 분수 약분
			int minNumer = sumNumer / gcm;
			int minDenom = lcm / gcm;

			answer[0] = minNumer;
			answer[1] = minDenom;
			return answer;
		}

		// 최소 공배수 출처 : chatgpt
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

		// 최대 공약수 출처 : chatgpt
		public int GCD(int num1, int num2)
		{
			while (num2 != 0)
			{
				int temp = num2;
				num2 = num1 % num2;
				num1 = temp;
			}
			return num1;
		}
}