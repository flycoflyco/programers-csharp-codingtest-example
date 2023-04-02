using System;
using System.Collections.Generic;
using System.Linq;

namespace Programers_codetest_example
{
	internal class Program
	{
        public static void Main()
		{
			int cnt = 0;
			string input = Console.ReadLine();
			for ( int i = 0; i < input.Length; i++)
			{
				char c = input[i];

				if (c == 'c' && i < input.Length-1 && input[i + 1] == '=')
				{
					cnt++;
					i++;
				}
				else if (c == 'c' && i < input.Length-1 && input[i + 1] == '-')
				{
					cnt++;
					i++;
				}
				else if (c == 'd' && i < input.Length - 2 && input[i + 1] == 'z' && input[i + 2] == '=')
				{
					cnt++;
					i+=2;
				}
				else if (c == 'd' && i < input.Length-1 && input[i + 1] == '-')
				{
					cnt++;
					i++;
				}
				else if (c == 'l' && i < input.Length-1 && input[i + 1] == 'j')
				{
					cnt++;
					i++;
				}
				else if (c == 'n' && i < input.Length-1 && input[i + 1] == 'j')
				{
					cnt++;
					i++;
				}
				else if (c == 's' && i < input.Length-1 && input[i + 1] == '=')
				{
					cnt++;
					i++;
				}
				else if (c == 'z' && i < input.Length-1 && input[i + 1] == '=')
				{
					cnt++;
					i++;
				}
				else
				{
					cnt++;
				}
					
			}
			Console.WriteLine(cnt);
		}

    }
}
