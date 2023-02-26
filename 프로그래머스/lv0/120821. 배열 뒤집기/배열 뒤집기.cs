using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int[] num_list) 
    {
			int[] answer = new int[] { };
			List<int> list = new List<int>(num_list);
			list.Reverse();
			answer = list.ToArray();
			return answer;
    }
}