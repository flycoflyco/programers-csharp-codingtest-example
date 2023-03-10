using System;

public class Solution {
    public int solution(string[] spell, string[] dic) {
			int answer = 2;

			for ( int i = 0; i < dic.Length; i++)
			{
				string dc1 = dic[i];
				bool contains = false;
				for (int j = 0; j< spell.Length; j++)
				{
					string sp1 = spell[j];
					if (dc1.Contains(sp1))
					{
						contains = true;
					}
					else
					{
						contains = false;
						break;
					}
				}

				if (contains)
				{
					answer = 1;
					break;
				}
			}
			return answer;
    }
}