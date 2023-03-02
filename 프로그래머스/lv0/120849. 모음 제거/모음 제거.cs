using System;

public class Solution {
    public string solution(string my_string) {
			string answer = "";

			foreach( char ch in my_string)
			{
				if (!( ch == 'i' || ch == 'a' || ch == 'e' || ch == 'o' || ch == 'u'))
				{
					answer += ch;
				}
			}
			
			return answer;
    }
}