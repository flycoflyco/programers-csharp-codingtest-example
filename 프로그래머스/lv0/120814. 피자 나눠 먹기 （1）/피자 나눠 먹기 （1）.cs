using System;

public class Solution {
    public int solution(int n) 
    {
			int answer = 1;

			int piece = 7;
			int pizzaNum = 1;

			while(n > (pizzaNum * piece))
			{
				pizzaNum++;
			}

			answer = pizzaNum;

			return answer;
    }
}