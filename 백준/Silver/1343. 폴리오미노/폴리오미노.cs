using System;
using System.Collections.Generic;

namespace ConsoleApp34
{
	public class Program
	{
		public static void Main()
		{
			string inputStr = Console.ReadLine();
			char prev = ' ';

			List<string> lst = new List<string>();
			List<char> chLst = new List<char>();
			string str = string.Empty;

			// x 랑 . 분리
			for ( int i = 0; i < inputStr.Length; i++)
			{
				char ch = inputStr[i];
				if ( i == 0 )
				{
					chLst.Add(ch);
					prev = ch;
					if (inputStr.Length == 1)
					{
						str = new string(chLst.ToArray());
						lst.Add(str);
					}
					continue;
				}

				if ( ch != prev )
				{
					str = new string(chLst.ToArray());
					lst.Add(str);
					chLst = new List<char>();
				}
				chLst.Add(ch);
				prev = ch;

				if (i == inputStr.Length - 1)
				{
					str = new string(chLst.ToArray());
					lst.Add(str);
				}
			}

			string result = "-1";
			bool flag = false;
			chLst = new List<char>();
			for (int i = 0; i < lst.Count; i++ )
			{
				
				string index = lst[i];

				if (index[0] == 'X' && index.Length % 2 != 0)
				{
					flag = true;
					break;
				}
				else if ( index[0] == 'X')
				{
					int margin = index.Length % 4;

					if (margin == 0)
					{
						for ( int j = 0; j < index.Length; j++)
						{
							chLst.Add('A');
						}
					}
					else
					{
						int mok = index.Length / 4;
						for (int j = 0; j < mok * 4; j++)
						{
							chLst.Add('A');
						}
						chLst.Add('B');
						chLst.Add('B');
					}
				}
				else
				{
					for (int j = 0; j < index.Length; j++)
					{
						chLst.Add(index[j]);
					}
				}
			}

			if (!flag)
				result = new string(chLst.ToArray());
			
			Console.WriteLine(result);
		}
	}
}

