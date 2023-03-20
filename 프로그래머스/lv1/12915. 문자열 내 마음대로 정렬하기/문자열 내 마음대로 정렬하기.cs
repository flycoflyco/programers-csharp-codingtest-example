public class Solution {
    public string[] solution(string[] strings, int n) {
			string[] answer = new string[strings.Length];


			for ( int i = 0; i < strings.Length-1; i++)
			{
				for (int j = 0; j < strings.Length-1; j++)
				{
					if ( strings[j][n] > strings[j+1][n])
					{
						string temp = strings[j];
						strings[j] = strings[j + 1];
						strings[j + 1] = temp;
					}
					else if (strings[j][n] == strings[j + 1][n])
					{
						//동일하면 0, 첫번째 문자열이 클경우 1, 두번째 문자열이 클경우 -1
						int cmp = string.Compare(strings[j], strings[j + 1]);
						if ( cmp > 0)
						{
							string temp = strings[j];
							strings[j] = strings[j + 1];
							strings[j + 1] = temp;
						}
					}
				}
			}
			answer = strings;

			return answer;
    }
}