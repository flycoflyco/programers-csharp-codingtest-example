using System;
using System.Collections.Generic;

namespace ConsoleApp34
{
	public class Program
	{
		public static void Main()
		{
			try
			{
				while(true)
				{
					string inputStr = Console.ReadLine();
					if (inputStr == string.Empty || inputStr == null)
						break;

					string[] inputStrSplit = inputStr.Split(' ');
					if (inputStrSplit == null || inputStrSplit.Length != 2)
						break;

					char[] s = inputStrSplit[0].ToCharArray();
					if (s == null || s.Length == 0)
						break;
					char[] t = inputStrSplit[1].ToCharArray();
					if (t == null || t.Length == 0)
						break;

					int sIndex = 0;
					for (int i = 0; i < t.Length; i++)
					{
						if (sIndex == s.Length)
							break;

						if (s[sIndex] == t[i])
						{
							sIndex++;
						}
					}

					if (sIndex == s.Length)
						Console.WriteLine("Yes");
					else
						Console.WriteLine("No");
				}
			}
			catch
			{

			}


		}

	}
}