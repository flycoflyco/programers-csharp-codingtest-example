using System;

public class Solution {
    public int solution(int[] sides)
    {
			int answer = 0;

			int maxIndex = -1;
			int maxValue = int.MinValue;
			for (int i = 0; i < sides.Length; i++)
			{
				int indexNum = sides[i];
				if ( maxValue < indexNum)
				{
					maxIndex = i;
					maxValue = indexNum;
				}
			}

			int otherSum = 0;
			for (int i = 0; i < sides.Length; i++)
			{
				if (i == maxIndex)
					continue;

				int indexNum = sides[i];
				otherSum = otherSum + indexNum;
			}

			if (maxValue < otherSum)
				answer = 1;
			else
				answer = 2;
			return answer;
    }
}