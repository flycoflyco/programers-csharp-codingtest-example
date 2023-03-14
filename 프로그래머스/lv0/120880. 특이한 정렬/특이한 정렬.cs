using System;

public class Solution {
    public int[] solution(int[] numlist, int n) {
			int[] answer = new int[] { };

			

			for (int i = 0; i < numlist.Length - 1; i++)
			{
				for (int j = 0; j < numlist.Length - 1; j++)
				{
					if ((Math.Abs(numlist[j] - n) > Math.Abs(numlist[j + 1] - n)) || 
						(Math.Abs(numlist[j] - n) == Math.Abs(numlist[j + 1] - n) && numlist[j] < numlist[j + 1]))
					{
						int nTemp = numlist[j + 1];
						numlist[j + 1] = numlist[j];
						numlist[j] = nTemp;
					}
				}
			}

			answer = numlist;

			return answer;
    }
}