using System;
namespace ConsoleApp6
{
	class Program
	{
		public static void Main(string[] args)
		{
			string inputStr = Console.ReadLine();
			int inputNum = int.Parse(inputStr);
			int prev = 0;
			int prevprev = 0;
			int curr = 0;
			for(int i = 0; i <= inputNum; i++)
			{
				if (i == 0)
					curr = 0;
				else if (i == 1)
					curr = 1;
				else
					curr = prev + prevprev;

				prevprev = prev;
				prev = curr;
			}
			Console.WriteLine(curr);

		}
	}
}