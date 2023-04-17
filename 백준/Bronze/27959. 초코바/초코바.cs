using System;

namespace Programers_codetest_example
{
	public  class Program
	{
		public static void Main()
		{
			string inputByStr = Console.ReadLine();
			string[] inputSplit = inputByStr.Split(' ');

			int inputNum1 = Convert.ToInt32(inputSplit[0]);
			int inputNum2 = Convert.ToInt32(inputSplit[1]);

			if ((inputNum1 * 100) >= inputNum2)
				Console.WriteLine("Yes");
			else
				Console.WriteLine("No");


		}




	}
}
