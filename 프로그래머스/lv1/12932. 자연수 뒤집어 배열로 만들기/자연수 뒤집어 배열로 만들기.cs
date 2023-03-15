using System.Collections.Generic;
using System;
public class Solution {
    public int[] solution(long n) {
			int[] answer = new int[] { };
			List<int> anList = new List<int>();
			string nStr = n.ToString();
			for (int i = 0; i < nStr.Length; i++)
			{
				char ch = nStr[i];
				anList.Add(Convert.ToInt32(ch.ToString()));
			}
			anList.Reverse();
			answer = anList.ToArray();
			return answer;
    }
}