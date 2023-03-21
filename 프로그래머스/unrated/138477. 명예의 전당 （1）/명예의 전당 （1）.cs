using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int k, int[] score) {
			int[] answer = new int[score.Length];
			List<int> hallofFame = new List<int>();
			
			for ( int i = 0; i < score.Length; i++)
			{
				hallofFame.Add(score[i]);
				hallofFame.Sort();
				hallofFame.Reverse();
				if (hallofFame.Count == k+1)
				{
					// 명예의 전당 숫자보다 커진경우
					hallofFame.RemoveAt(hallofFame.Count - 1);
				}

				answer[i] = hallofFame[hallofFame.Count - 1];
			}
			return answer;
    }
}