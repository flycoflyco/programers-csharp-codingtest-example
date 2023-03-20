using System;

public class Solution {
    public int solution(int a, int b, int n) {
			int answer = 0;

			int temp = n;
			int margin = 0;
			while (true)
			{
				margin += temp % a;
				temp = temp / a;
				temp = temp * b;
				answer += temp;

				if ( temp < a)
				{
					temp = temp + margin;
					margin = 0;
					if (temp < a)
						break;
				}
			}
			return answer;
    }
}