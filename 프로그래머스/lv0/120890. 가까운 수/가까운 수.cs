using System;

public class Solution {
    public int solution(int[] array, int n) {
			int answer = 0;
			
			int closeIndex = 0;
			int closeNum = int.MaxValue;
			for (int i = 0; i < array.Length; i++)
			{
				int num = array[i];
				if (Math.Abs(num - n) <= closeNum)
				{
					if (Math.Abs(num - n) == closeNum)
					{
						if (num < array[closeIndex])
						{
							closeIndex = i;
						}
					}
					else
					{
						closeIndex = i;
						closeNum = Math.Abs(num - n);
					}
				}
			}
			answer = array[closeIndex];
			return answer;
    }
}