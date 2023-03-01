using System;

public class Solution {
    public int[] solution(int[] numbers, string direction)
    {
			int[] answer = new int[numbers.Length];
			if (direction == "left")
			{
				// 왼쪽 이동시 처음 값이 마지막으로
				answer[numbers.Length - 1] = numbers[0];
				for (int i = 0; i < numbers.Length-1; i++)
				{
					answer[i] = numbers[i+1];
				}
			}
			else
			{
				// 오른쪽 이동시 마지막이 처음으로
				answer[0] = numbers[numbers.Length - 1];
				for (int i = 1; i < numbers.Length; i++)
				{
					answer[i] = numbers[i-1];
				}
			}
			return answer;
    }
}