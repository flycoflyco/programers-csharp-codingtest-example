using System.Collections.Generic;
public class Solution {
    public string solution(string s) {
			string answer = "";

			List<char> chList = new List<char>();

			for (int i = 0; i < s.Length; i++)
			{
				chList.Add(s[i]);
			}

			chList.Sort();
			chList.Reverse();

			answer = new string(chList.ToArray());

			return answer;
    }
}