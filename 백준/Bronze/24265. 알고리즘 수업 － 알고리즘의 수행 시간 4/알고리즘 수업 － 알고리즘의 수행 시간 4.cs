using System;

namespace Programers_codetest_example
{
	public  class Program
	{
		public static void Main()
		{
			string inputByStr = Console.ReadLine();
			long inputNum = Convert.ToInt32(inputByStr);
			long result = ((inputNum * inputNum) - inputNum) / 2;
			Console.WriteLine(result);
			Console.WriteLine(2);


		}


	}
}
