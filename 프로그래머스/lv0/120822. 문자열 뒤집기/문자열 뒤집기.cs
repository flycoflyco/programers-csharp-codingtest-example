using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution {
    public string solution(string my_string)
    {
        	IEnumerable<char> test = my_string.Reverse();
			var sb = new StringBuilder();
			foreach (var c in test)
			{
				sb.Append(c);
			}
			return sb.ToString();
    }
}