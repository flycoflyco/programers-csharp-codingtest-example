using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp34
{
	public class Program
	{
		public static void Main()
		{
			string str = Console.ReadLine();
			int cnt = 0;
			string[] strSplit = str.Split(' ');
			for ( int i = 0; i < strSplit.Length; i++)
			{
				string s = strSplit[i];
				if (s != "")
					cnt++;
			}
			Console.WriteLine(cnt++);
		}
	}
}

