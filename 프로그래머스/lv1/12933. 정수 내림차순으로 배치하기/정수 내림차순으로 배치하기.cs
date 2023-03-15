using System;
using System.Collections.Generic;
public class Solution {
    public long solution(long n) {
			long answer = 0;
			List<long> list = new List<long>();
			string s = n.ToString();
			for(int i = 0; i < s.Length; i++)
			{
				char ch = s[i];
				list.Add(Convert.ToInt64(ch.ToString()));
			}
			list.Sort(delegate (long l1, long l2)
		   {
			   return l2.CompareTo(l1);
		   });
			string tempStr = "";
			for ( int i = 0; i < list.Count; i++)
			{
				tempStr += list[i];
			}
			answer = Convert.ToInt64(tempStr);
			return answer;
    }
}