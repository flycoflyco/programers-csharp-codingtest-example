using System;

public class Solution {
    public string solution(string polynomial) {
			string answer = "";

			string[] splitStr = polynomial.Split(' ');

			int sumNum = 0;
			int sumPoly = 0;

			for (int i = 0; i < splitStr.Length; i++)
			{
				string strIndex = splitStr[i];

				if (strIndex == "+")
					continue;

				if ( strIndex.Contains("x"))
				{
					string num = strIndex.Remove(strIndex.Length - 1);

					int number = 0;
					if (num == string.Empty)
						number = 1;
					else
						number = Convert.ToInt32(num);

					sumPoly += number;
				}
				else
				{
					sumNum += Convert.ToInt32(strIndex);
				}
			}

			if (sumPoly != 0)
			{
				if (sumPoly == 1)
					answer += "x";
				else
					answer += sumPoly.ToString() + "x";
			}

			if (sumPoly != 0 && sumNum != 0)
			{
				answer += " + ";
			}

			if (sumNum != 0)
				answer += sumNum.ToString();


			return answer;
    }
}