using System;

public class Solution {
    public string solution(string s) {
        string answer = "";
        string[] str = s.Split(' ');

        int min = int.MaxValue;
        int max = int.MinValue;

        for (int i = 0; i < str.Length; i++)
		{
            string st = str[i];
            int indexNum = Convert.ToInt32(st);
            
            if (indexNum < min)
                min = indexNum;

            if (indexNum > max)
                max = indexNum;
		}
        answer = min + " " + max;

        return answer;
    }
}