using System;

namespace ConsoleApp34
{
	public class Program
	{
		public static void Main()
		{
			string inputStr = Console.ReadLine();
			ulong input = Convert.ToUInt64(inputStr);

			ulong num = input - 2;
			ulong result = ((num * num * num) + (3 * num * num) + (2 * num)) / 6;

			Console.WriteLine(result);
			Console.WriteLine(3);
		}
	}
}

