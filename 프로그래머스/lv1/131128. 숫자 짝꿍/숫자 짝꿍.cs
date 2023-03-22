using System;
using System.Collections.Generic;
using System.Text;

public class Solution {
    public string solution(string X, string Y) {
			string answer = "";

			string longStr = "";
			string shortStr = "";
			if (X.Length > Y.Length)
			{
				longStr = X;
				shortStr = Y;
			}
			else
			{
				longStr = Y;
				shortStr = X;
			}

			int[] longArr = new int[10];
			int[] shortArr = new int[10];
			int[] answerArray = new int[10];

			List<char> coupleNums = new List<char>();
			List<char> containsChList = new List<char>();

			for ( int i = 0; i < shortStr.Length; i++)
			{
				int index = Convert.ToInt32(shortStr[i].ToString());
				shortArr[index]++;
			}


			for (int i = 0; i < longStr.Length; i++)
			{
				int index = Convert.ToInt32(longStr[i].ToString());
				longArr[index]++;
			}

			

			for ( int i = 0; i < 10; i++)
			{
				if ( shortArr[i] != 0 && longArr[i] != 0)
				{
					if (shortArr[i] < longArr[i])
					{
						answerArray[i] = shortArr[i];
					}
					else
					{
						answerArray[i] = longArr[i];
					}
				}
			}
			StringBuilder sb = new StringBuilder();

			bool isOnlyZero = true;
			bool isEmpty = true;

			for (int i = answerArray.Length-1; i >= 0 ; i--)
			{
				int num = answerArray[i];

				if (num == 0)
				{
					continue;
				}
				else if (i != 0 && num != 0)
				{
					isOnlyZero = false;
					isEmpty = false;
				}
				else
				{
					isEmpty = false;
				}


				for (int j = 0; j < num; j++)
				{
					sb.Append(i);
				}
			}

			if (isEmpty)
				return "-1";

			if (isOnlyZero)
				return "0";




			answer = sb.ToString();

			return answer;
    }
}