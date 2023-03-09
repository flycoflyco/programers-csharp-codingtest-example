using System;

public class Solution {
    public int solution(int[] sides) {
			int answer = 0;
			// x,y 주어진 숫자 (x 가 큰수)
			int x = sides[0];
			int y = sides[1];
			if (x < y)
			{
				x = sides[1];
				y = sides[0];
			}

			answer = (2 * y) - 1;



			//// z가 몇개인지 찾아야 하는 문제

			//// 1. z > x 경우
			//// x < z < x+y  일때 정수의 z 의 개수
			//if (y - 1 > 0)
			//	answer += y - 1;

			//// 2. z < x 경우
			//// x - y <  z < x
			//if (y > 0)
			//	answer += y;


			return answer;
    }
}