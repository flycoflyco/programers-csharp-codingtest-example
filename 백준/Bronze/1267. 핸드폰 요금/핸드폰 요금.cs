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

			string inputStr2 = Console.ReadLine();
			string[] callTimesStr = inputStr2.Split(' ');
			int[] callTimes = new int[callTimesStr.Length];
			for ( int i = 0; i < callTimesStr.Length; i++ )
            {
				callTimes[i] = Convert.ToInt32(callTimesStr[i]);
            }
			
			int y = 0;
			int m = 0;

			for ( int i = 0; i < callTimes.Length; i++ )
            {
				int time = callTimes[i];
				
				int yPay = time / 30;
				//if (time % 30 > 0)
				yPay++;

				y += yPay * 10;

				int mPay = time / 60;
				//if (time % 60 > 0)
				mPay++;

				m += mPay * 15;
            }

			if (y > m)
				Console.WriteLine("M " + m);
			else if ( y == m)
				Console.WriteLine("Y M " + y);
			else
				Console.WriteLine("Y " + y);

		}



	}
}