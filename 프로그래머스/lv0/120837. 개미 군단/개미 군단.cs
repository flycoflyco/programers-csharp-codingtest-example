using System;

public class Solution {
    public int solution(int hp)
    {
			int answer = 0;

			int generalAnt = 5;
			int soldierAnt = 3;
			int ergate = 1;

			int first = hp % generalAnt;
			int firstNum = hp / generalAnt;
			if (first == 0)
			{
				answer = firstNum;
				return answer;
			}
			else
			{
				int second = first % soldierAnt;
				int secondNum = first / soldierAnt;
				if (second == 0)
				{
					answer = firstNum + secondNum;
				}
				else
				{
					answer = firstNum + secondNum + second;
				}
			}
			return answer;
    }
}