using System;
using System.Collections.Generic;

namespace ConsoleApp34
{
	public class Program
	{
		public static void Main()
		{
			string inputStr = Console.ReadLine();
			int inputNum = Convert.ToInt32(inputStr);
			char[] chArr = new char[inputNum];
			string str = Console.ReadLine();
			chArr = str.ToCharArray();

			List<char> list = new List<char>();
			for ( int i = 0; i < chArr.Length; i++)
            {
				if (chArr[i] == 'S')
                {
					if (list.Count == 0 || list[list.Count-1] != '*')
						list.Add('*');

					list.Add('S');
					list.Add('*');
				}
				else if (chArr[i] == 'L' )
                {
					if (list.Count == 0 || list[list.Count-1] != '*')
						list.Add('*');

					list.Add('L');
					list.Add('L');
					list.Add('*');
					i++;
				}
            }

			List<char> checkLst = new List<char>();

			int cnt = 0;
			for ( int i = 0; i < list.Count; i++)
            {
				char ch = list[i];
				checkLst.Add(ch);

				if (checkLst.Count == 2)
                {
					if (checkLst.Contains('*'))
						cnt++;
					else
						i--;

					checkLst = new List<char>();
				}
            }

			Console.WriteLine(cnt);

		}



	}
}