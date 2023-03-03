using System;

public class Solution {
    public string solution(string my_string, int num1, int num2) 
    {
			string answer = "";
			char[] charArray = my_string.ToCharArray();
			char temp = charArray[num1];
			charArray[num1] = charArray[num2];
			charArray[num2] = temp;
			answer = new string(charArray);
			return answer;
    }
}