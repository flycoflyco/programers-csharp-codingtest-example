using System;

public class Solution {
    public string solution(int age)
    {
			string answer = "";
			int asciiNum = 97;
			string ageStr = age.ToString();
			foreach ( char ch in ageStr)
			{
				int num = Convert.ToInt32(ch.ToString());
				char convertChar = Convert.ToChar(asciiNum + num);
				answer += convertChar;
			}
			return answer;
    }
}