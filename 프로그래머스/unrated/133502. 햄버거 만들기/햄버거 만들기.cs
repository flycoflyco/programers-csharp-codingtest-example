using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] ingredient) {
			int answer = 0;
			
			int i = 0;

			List<int> ingList = new List<int>(ingredient);
			List<int> buger = new List<int>(4);

			while (i < ingList.Count)
			{
				int inNum = ingList[i];

				if (buger.Count == 0 && inNum == 1)
				{
					buger.Add(inNum);
				}
				else if (buger.Count == 1 && buger[0] == 1 && inNum == 2)
				{
					buger.Add(inNum);
				}
				else if (buger.Count == 2 && inNum == 3)
				{
					buger.Add(inNum);
				}
				else if (buger.Count == 3 && inNum == 1)
				{
					buger.Add(inNum);
				}
				else
				{
					buger = new List<int>(4);
					buger.Add(inNum);
				}

				i++;

				if (buger.Count == 4)
				{
					ingList.RemoveRange(i - 4, 4);
					buger = new List<int>(4);
					answer++;

					if (i - 4 - 2 < 0)
						i = 0;
					else
						i = i - 4 - 2;

					if (ingList.Count == 0)
						break;
				}
			}
			return answer;
    }
}