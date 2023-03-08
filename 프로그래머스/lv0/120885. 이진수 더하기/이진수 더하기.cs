using System;
using System.Linq;
public class Solution {

		public string solution(string bin1, string bin2)
		{
			string answer = "";
			int num1 = GetDec(bin1);
			int num2 = GetDec(bin2);
			answer = GetBin(num1 + num2);
			return answer;
		}

		public int GetDec(string bin)
		{
			int result = 0;

			char[] binArr = bin.ToCharArray();
			int raise = 0; // 지수부

			for (int i = binArr.Length-1; i >= 0; i--)
			{
				char ch = binArr[i];
				if (ch == '1')
				{
					if (raise == 0)
					{
						result += 1;
					}
					else
					{
						int n = 1;
						for (int j = 0; j < raise; j++)
						{
							n *= 2;
						}
						
						result += n;

					}
				}
				raise++;
			}

			return result;
		}

		public string GetBin(int decNum)
		{
			string result = string.Empty;

			if (decNum == 0)
				return "0";

			if (decNum == 1)
				return "1";


			int mok = decNum;
			int margin = 0;
			while(true)
			{
				margin = mok % 2;
				result += margin.ToString();
				mok = mok / 2;

				if (mok == 1)
				{
					result += "1";
					break;
				}
			}

			int strIndex = 0;
			char[] charray = new char[result.Length];
			for (int i = result.Length-1; i >= 0; i--)
			{
				char ch = result[i];
				charray[strIndex] = ch;
				strIndex++;
			}

			result = new string(charray);
			
			return result;
		}
}