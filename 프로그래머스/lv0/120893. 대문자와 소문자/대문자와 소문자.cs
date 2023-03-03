using System;
using System.Collections.Generic;

public class Solution {
    public string solution(string my_string) {
			string answer = "";
			List<char> lst = new List<char>();

			foreach (char ch in my_string)
			{
				if ( 64 < ch && ch < 91)
				{
					// 대문자
					answer += Convert.ToChar(ch + 32);
					
				}
				else if (96 < ch && ch < 123)
				{
					// 소문자
					answer += Convert.ToChar(ch - 32);
				}
			}
			


			return answer;
    }
}