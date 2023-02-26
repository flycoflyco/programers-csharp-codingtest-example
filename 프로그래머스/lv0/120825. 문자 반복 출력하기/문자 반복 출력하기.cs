using System;

public class Solution {
    public string solution(string my_string, int n) 
    {
			string answer = "";

			foreach (char index in my_string)
			{
				for (int i = 0; i < n; i++)
				{
					answer = answer + index;
				}
			}

			return answer;
    }
}