using System;

namespace ConsoleApp34
{
	public class Program
	{
		public static void Main()
		{
			string inputStr1 = Console.ReadLine();
			string inputStr2 = Console.ReadLine();
			string inputStr3 = Console.ReadLine();

			string[] inputSplit = inputStr1.Split(' ');

			int a1 = Convert.ToInt32(inputSplit[0]);
			// a1 = Math.Abs(a1);
			int a0 = Convert.ToInt32(inputSplit[1]);
			// a0 = Math.Abs(a0);

			int c = Convert.ToInt32(inputStr2);

			int n0 = Convert.ToInt32(inputStr3);


			int absN0 = Math.Abs(n0);
			int indexN0 = 0;

			bool flag = true;
			for (int i = absN0; i <= 100; i++)
			{
				if (n0 < 0)
					indexN0 = i * -1;
				else
					indexN0 = i;

				if ((a1 * indexN0) + a0 <= c * indexN0)
				{
					flag = true;
				}
				else
				{
					flag = false;
					break;
				}
			}

			if (!flag)
				Console.WriteLine(0);
			else
				Console.WriteLine(1);
		}
	}
}

