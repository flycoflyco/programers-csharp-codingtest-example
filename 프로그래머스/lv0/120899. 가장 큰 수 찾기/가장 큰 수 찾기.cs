using System;

public class Solution {
		public int[] solution(int[] array)
		{
			int[] answer = new int[2];
			int maxindex = -1;
			int maxValue = int.MinValue;

			
			for (int i = 0; i < array.Length; i++)
			{
				int indexValue = array[i];
				if (indexValue > maxValue)
				{
					maxValue = indexValue;
					maxindex = i;
				}
			}
			answer[0] = maxValue;
			answer[1] = maxindex;
			return answer;
		}
}