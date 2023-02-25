using System;

public class Solution {
    public int solution(int n) 
    {
			int answer = 0;
			int num = n;

			if ( n % 2 == 1)
				num = n - 1;


			for (int i = 2; i <= n; i+=2)
				answer = answer + i;


			return answer;
    }
}