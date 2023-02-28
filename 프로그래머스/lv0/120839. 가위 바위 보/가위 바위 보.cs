using System;

public class Solution {
    public string solution(string rsp) 
    {
			string answer = "";
			foreach(char ch in rsp)
			{
				if (ch == 48)
				{
					answer += "5";
				}
				else if (ch == 50)
				{
					answer += "0";
				}
				else
				{
					answer += "2";
				}
			}
			return answer;
    }
}