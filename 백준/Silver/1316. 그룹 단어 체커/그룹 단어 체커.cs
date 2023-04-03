using System;
using System.Collections.Generic;
using System.Linq;

namespace Programers_codetest_example
{
	internal class Program
	{
		public static void Main()
		{
			int count = int.Parse(Console.ReadLine());
			int answer = count;

			for (int i = 0; i < count; i++)
			{
				string word = Console.ReadLine();
				List<char> alphbet = new List<char>();
				char prev = ' ';
				foreach (char ch in word)
				{
					if (ch != prev)
					{
						if (alphbet.Contains(ch))
						{
							answer--;
							break;
						}
						alphbet.Add(ch);
					}
					prev = ch;
				}
			}
			Console.WriteLine(answer);
		}

	}
}
