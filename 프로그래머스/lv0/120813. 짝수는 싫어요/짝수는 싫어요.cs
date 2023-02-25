using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int n) 
    {
			int[] answer = new int[] { };

			List<int> list = new List<int>();

			int num = n;
			if (num % 2 == 0)
				num--;

			for (int i = 1; i <= num; i += 2)
			{
				list.Add(i);
			}

			answer = list.ToArray();

			return answer;
    }
}