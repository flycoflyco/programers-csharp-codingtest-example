using System;

public class Solution {
    public int solution(string s) 
    {
			int answer = 0;
			int prevNum = 0;
			string[] splitStr = s.Split(' ');

			for(int i = 0; i < splitStr.Length; i++)
			{
				string indexStr = splitStr[i];
				if (indexStr == "Z" || indexStr == "z")
				{
					answer = answer + (prevNum * -1);
				}
				else
				{
					int strNum = Convert.ToInt32(indexStr);
					answer = answer + strNum;
					prevNum = strNum;
				}
			}
			return answer;
    }
}