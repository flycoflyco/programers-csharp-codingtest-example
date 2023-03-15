using System;
public class Solution {
    public bool solution(int x) {
			bool answer = true;

			int sum = 0;
			string str = x.ToString();
			for (int i = 0; i <str.Length; i++)
			{
				char ch = str[i];
				sum += Convert.ToInt32(ch.ToString());
			}

			if ( x % sum == 0)
				answer = true;
			else
				answer = false;

			return answer;
    }
}