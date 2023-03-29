using System;
using System.Collections.Generic;

public class Solution {
    public bool solution(string s) {
			bool answer = true;
			Stack<bool> st = new Stack<bool>();

			for ( int i = 0; i < s.Length; i++)
			{
				char ch = s[i];
				if (st.Count == 0 && ch == ')')
				{
					return false;
				}
				else
				{
					if ( ch == '(')
						st.Push(true);
					else
					{
						if (st.Count > 0)
							st.Pop();
						else
							return false;
					}
						
				}
			}
			if (st.Count != 0)
				answer = false;

			return answer;
    }
}