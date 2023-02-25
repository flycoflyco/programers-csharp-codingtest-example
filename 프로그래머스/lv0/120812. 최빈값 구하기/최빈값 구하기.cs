using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int[] array) 
    {
			int answer = 0;

			Dictionary<int, int> dic = new Dictionary<int, int>();

			for (int i = 0; i < array.Length; i++)
			{
				if ( !dic.ContainsKey(array[i]))
				{
					dic.Add(array[i], 1);
				}
				else
				{
					dic[array[i]]++;
				}
			}

			if (dic.Count == 0)
				answer = -1;

			var list = dic.OrderByDescending(x => x.Value).ToList();

			if (dic.Count == 1)
				answer = list[0].Key;
			else if (list[0].Value == list[1].Value)
				answer = -1;
			else
				answer = list[0].Key;


			return answer;
    }
}