using System.Collections.Generic;

public class Solution {
    public int solution(string s) {
			int answer = 0;

			int xCnt = 0;
			int notXCnt = 0;
			// List<string> lst = new List<string>();
			List<char> chLst = new List<char>();
			// char x = s[0];
			for (int i = 0; i < s.Length; i++)
			{
				char x = s[i];
				if ( chLst.Count == 0)
				{
					chLst.Add(x);
					xCnt++;
				}
				else
				{
					if ( chLst[0] == x)
					{
						xCnt++;
					}
					else
					{
						notXCnt++;
					}
				}

				if (xCnt == notXCnt)
				{
					answer++;
					chLst = new List<char>();
				}
				else if (i == s.Length-1)
				{
					answer++;
				}
			}



			return answer;
    }
}