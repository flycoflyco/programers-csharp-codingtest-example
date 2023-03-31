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
			int cnt = 0;
			string num = Console.ReadLine();
			string arrStr = Console.ReadLine();
			string v = Console.ReadLine();

			string[] arr = arrStr.Split(' ');

			for ( int i = 0; i < arr.Length; i++)
			{
				string s = arr[i];
				if (s == v)
					cnt++;
			}

			Console.WriteLine(cnt);
		}
	}
}
