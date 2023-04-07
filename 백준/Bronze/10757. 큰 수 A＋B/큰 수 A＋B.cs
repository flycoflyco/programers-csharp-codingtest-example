using System;
using System.Linq;

namespace ConsoleApp34
{
	public class Program
	{
		public static void Main()
		{
			string inputStr = Console.ReadLine();
			string[] inputSplit = inputStr.Split(' ');
			string a = inputSplit[0];
			string b = inputSplit[1];

			if (b.Length > a.Length)
			{
				string temp = a;
				a = b;
				b = temp;
			}

			a = new string(a.Reverse().ToArray());
			b = new string(b.Reverse().ToArray());

			string answer = string.Empty;

			int upper = 0;
			for ( int i = 0; i < a.Length; i++)
			{
				char aChar = a[i];
				int aInt = Convert.ToInt32(aChar.ToString());
				int bInt = 0;
				if (i < b.Length)
				{
					char bChar = b[i];
					bInt = Convert.ToInt32(bChar.ToString());
				}



				if ( aInt + bInt + upper >= 10)
				{
					string temp = (aInt + bInt + upper).ToString();
					if (i == a.Length - 1)
					{
						answer += temp[1];
						answer += temp[0];
						upper = 0;
					}
					else
					{
						answer += temp[1];
						upper = 1;
					}
				}
				else
				{
					answer += aInt + bInt + upper;
					upper = 0;
				}
			}

			answer = new string(answer.Reverse().ToArray());

			Console.WriteLine(answer);

		}
	}
}

