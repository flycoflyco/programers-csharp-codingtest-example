using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int n, int[] numlist) {
			int[] answer = new int[] { };
			List<int> answerList = new List<int>();
			for ( int i = 0; i < numlist.Length; i++)
			{
				int num = numlist[i];
				if (num % n  == 0)
					answerList.Add(num);
			}
			answer = answerList.ToArray();
			return answer;
    }
}