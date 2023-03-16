using System.Collections.Generic;
public class Solution {
    public int[] solution(int[] arr, int divisor) {
			int[] answer = new int[] { };
			List<int> anList = new List<int>();
			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] % divisor == 0)
				{
					anList.Add(arr[i]);
				}
			}
			if (anList.Count == 0)
			{
				answer = new int[1] { -1 };
				return answer;
			}
			else
			{
				anList.Sort();
				answer = anList.ToArray();
				return answer;
			}
    }
}