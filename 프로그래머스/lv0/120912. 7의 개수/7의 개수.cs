using System;

public class Solution {
    public int solution(int[] array) {
			int answer = 0;
			for (int i = 0; i < array.Length; i++)
			{
				int num = array[i];
				string numStr = num.ToString();
				for (int j = 0; j < numStr.Length; j++)
				{
					char ch = numStr[j];
					if (ch == '7')
						answer++;
				}
			}
			return answer;
    }
}