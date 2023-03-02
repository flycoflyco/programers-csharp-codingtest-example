using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string my_string) {
			int[] answer = new int[] { };

			List<int> integerList = new List<int>();
			foreach (char ch in my_string)
			{
				if (ch > 47 && ch < 58)
				{
					integerList.Add(Convert.ToInt32(ch.ToString()));
				}
			}
			integerList.Sort();
			answer = integerList.ToArray();
			return answer;
    }
}