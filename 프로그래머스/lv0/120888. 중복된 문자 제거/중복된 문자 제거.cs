using System;
using System.Collections.Generic;
public class Solution {
    public string solution(string my_string) 
    {
			string answer = "";
			List<char> answerList = new List<char>();
			foreach (char ch in my_string)
			{
				if (!answerList.Contains(ch))
				{
					answerList.Add(ch);
				}
			}
			answer = new string(answerList.ToArray());
			return answer;
    }
}