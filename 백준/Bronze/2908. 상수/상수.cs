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
			string twoNums = Console.ReadLine();
			string[] numsSplits = twoNums.Split(' ');
			string firstNum = new string(numsSplits[0].Reverse().ToArray());
			string secondNum = new string(numsSplits[1].Reverse().ToArray());
			if ( Convert.ToInt32(firstNum) > Convert.ToInt32(secondNum))
				Console.WriteLine(firstNum);
			else
				Console.WriteLine(secondNum);


		}
	}
}

