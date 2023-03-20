using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string s) {
			int cnt = s.Length;
			int[] answer = new int[cnt];
			Dictionary<char, int> dic = new Dictionary<char, int>();
			for ( int i = 0; i < cnt; i++)
			{
				char ch = s[i];
				if (!dic.ContainsKey(s[i]))
				{
					dic.Add(ch, i);
					answer[i] = -1;
				}
				else
				{
					answer[i] = i - dic[ch];
					dic[ch] = i;
				}
			}

			return answer;
    }
}