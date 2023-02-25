using System;

public class Solution {
    public double solution(int[] numbers) 
    {
			double answer = 0;
			int total = 0;

			for (int i = 0; i < numbers.Length; i++)
			{
				total = total + numbers[i];
			}
			answer = (double)total / (double)numbers.Length;
			return answer;
    }
}