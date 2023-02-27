using System;
using System.Collections.Generic;
public class Solution {
    public int solution(int[] numbers)
    {
			int answer = 0;
			List<int> numList = new List<int>(numbers);
			numList.Sort();
			numList.Reverse();
			answer = numList[0] * numList[1];
			return answer;
    }
}