using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] emergency) 
    {
			int[] answer = new int[emergency.Length];
			List<int> emergencyList = new List<int>(emergency);
			emergencyList.Sort();
			emergencyList.Reverse();
			for ( int i = 0; i < emergency.Length; i++ )
			{
				int currentEmergency = emergency[i];
				int index = emergencyList.FindIndex(x => x == currentEmergency);
				index++;
				answer[i] = index;
			}
			return answer;
    }
}