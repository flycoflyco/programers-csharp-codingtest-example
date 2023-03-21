using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int k, int m, int[] score) {
			int answer = 0;
			List<int> appleList = new List<int>(score);
			appleList.Sort();
			appleList.Reverse();
			int boxCnt = 0;
			for ( int i =0; i < appleList.Count;i++)
			{
				boxCnt++;
				if (boxCnt == m)
				{
					answer += appleList[i] * m;
					boxCnt = 0;
				}
			}
			return answer;
    }
}