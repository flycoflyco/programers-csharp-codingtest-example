using System;
using System.Collections.Generic;

public class Solution {
    public string solution(string s) 
    {
			string answer = "";
			Dictionary<char, int> dic = new Dictionary<char, int>();

			foreach (char ch in s)
			{
				if (!dic.ContainsKey(ch))
				{
					dic.Add(ch, 1);
				}
				else
				{
					dic[ch]++;
				}
			}

			List<char> vs = new List<char>();

			foreach(char ch in dic.Keys)
			{
				if (dic[ch] == 1)
				{
					vs.Add(ch);
				}
			}
			vs.Sort();

			answer = new string(vs.ToArray());

			return answer;
    }
}