using System;

public class Solution {
    public int solution(int slice, int n)
    {
			int answer = 0;
			int pizzaNum = 1;

			while (n > (pizzaNum * slice))
			{
				pizzaNum++;
			}
			answer = pizzaNum;
			return answer;
    }
}