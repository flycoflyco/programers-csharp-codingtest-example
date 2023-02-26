using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string[] strlist)
    {
			int[] answer = new int[] { };

			List<int> cntList = new List<int>();

			for (int i = 0; i < strlist.Length; i++)
			{
				string str = strlist[i];
				cntList.Add(str.Length);
			}
			answer = cntList.ToArray();
			return answer;
    }
}