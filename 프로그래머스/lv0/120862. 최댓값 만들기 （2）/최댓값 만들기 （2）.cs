using System;

public class Solution {
    public int solution(int[] numbers) {
			int answer = 0;

			int maxValue = int.MinValue;

			for ( int i = 0; i < numbers.Length; i++)
			{
				for (int j = i; j < numbers.Length; j++)
				{
					if (i == j)
						continue;

					int cmpValue = numbers[i] * numbers[j];
					if ( maxValue < cmpValue)
					{
						maxValue = cmpValue;
					}
				}
			}
			answer = maxValue;
			return answer;
    }
}