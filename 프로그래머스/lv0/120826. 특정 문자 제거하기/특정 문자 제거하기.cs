using System;

public class Solution {
    public string solution(string my_string, string letter) 
    {
			string answer = "";

			foreach (char indexChar in my_string)
			{
				string indexStr = indexChar.ToString();
				if (!indexStr.Equals(letter))
				{
					answer += indexStr;
				}
			}

			return answer;
    }
}