using System.Collections.Generic;
public class Solution 
{
    public string solution(string[] cards1, string[] cards2, string[] goal) 
    {
			string answer = "Yes";

			Stack<string> st1 = new Stack<string>();
			Stack<string> st2 = new Stack<string>();

			for (int i = cards1.Length-1; i >=0; i--)
				st1.Push(cards1[i]);

			for (int i = cards2.Length-1; i >= 0; i--)
				st2.Push(cards2[i]);

			bool flag = false;
			for ( int i = 0; i < goal.Length; i++)
			{
				flag = false;
				string baseStr = goal[i];

				if (st1.Count != 0 && baseStr.Equals(st1.Peek()))
				{
					flag = true;
					st1.Pop();
				}

				if (st2.Count != 0 && baseStr.Equals(st2.Peek()))
				{
					flag = true;
					st2.Pop();
				}

				if (!flag)
				{
					answer = "No";
					break;
				}
			}
			return answer;
    }
}