using System;

namespace ConsoleApp34
{
	public class Program
	{
		public static void Main()
		{
			string inputStr1 = Console.ReadLine();
			int input = Convert.ToInt32(inputStr1);

			int result = 0;

			for ( int i = 1; i < input; i++)
			{
				int sum = i;

				string str = Convert.ToString(i);
				for ( int j = 0; j < str.Length; j++ )
				{
					char c = str[j];
					sum += Convert.ToInt32(c.ToString());
				}

				if ( sum == input)
				{
					result = i;
					break;
				}
			}

			Console.WriteLine(result);
		}
	}
}

