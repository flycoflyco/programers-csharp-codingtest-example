using System;
using System.Collections.Generic;
public class Solution {
    public string solution(string my_string) {
			string answer = "";
			List<char> chList = new List<char>();
			for ( int i = 0; i < my_string.Length; i++)
			{
				char ch = my_string[i];
				if ( 64 < ch && ch < 91)
				{
					ch = Convert.ToChar(ch + 32);
				}
				chList.Add(ch);
			}
			chList.Sort();
			answer = new string(chList.ToArray());
			return answer;
    }
}