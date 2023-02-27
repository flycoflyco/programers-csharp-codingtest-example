using System;

public class Solution {
    public int[] solution(int[] numbers, int num1, int num2) 
    {
			int[] answer = new int[num2 - num1 + 1];
			int answerIndex = 0;
			for (int i = 0; i < numbers.Length; i++)
			{
				int arrayValue = numbers[i];
				if ( num1 <= i && i <= num2)
				{
					answer[answerIndex] = arrayValue;
					answerIndex++;
				}
			}
			return answer;
    }
}