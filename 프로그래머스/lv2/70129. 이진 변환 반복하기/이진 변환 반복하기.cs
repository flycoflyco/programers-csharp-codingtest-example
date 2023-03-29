using System.Linq;

public class Solution {
    public int[] solution(string s) {
			int[] answer = new int[2];

			while(s != "1" )
			{

				for ( int i = 0; i < s.Length; i++)
				{
					if (s[i] == '0')
						answer[1]++;
				}

				s = s.Replace("0", "");
				int length = s.Length;
				int mok = length;
				int margin = 0;
				string tempStr = string.Empty;
				while (mok > 0)
				{
					margin = mok % 2;
					tempStr += margin;
					mok = mok / 2;
				}
				s = new string(tempStr.Reverse().ToArray());
				answer[0]++;
			}
			return answer;
    }
}