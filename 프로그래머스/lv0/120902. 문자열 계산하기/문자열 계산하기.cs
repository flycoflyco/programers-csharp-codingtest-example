using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string my_string)
    {
			int answer = 0;
			List<int> operand = new List<int>(); // 피연산자
			List<string> op = new List<string>(); // 연산자

			string[] splitStr = my_string.Split(' ');

			for (int i = 0; i < splitStr.Length; i++)
			{
				string indexStr = splitStr[i];
				int operandNum = 0;

				if (int.TryParse(indexStr, out operandNum))
					operand.Add(operandNum);
				else
					op.Add(indexStr);


				if ( operand.Count == 2 && op.Count == 1)
				{
					if (op[0] == "+")
					{
						int tmp = operand[0] + operand[1];
						operand.Clear();
						operand.Add(tmp);
						op.Clear();
					}
					else
					{
						int tmp = operand[0] - operand[1];
						operand.Clear();
						operand.Add(tmp);
						op.Clear();
					}
				}
			}

			answer = operand[0];

			return answer;
    }
}