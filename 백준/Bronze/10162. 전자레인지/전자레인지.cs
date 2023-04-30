using System;

namespace ConsoleApp34
{
	public class Program
	{
		public static void Main()
		{
			// int result = 0;
			int[] arr = { 300, 60, 10 };
			string inputStr1 = Console.ReadLine();
			int input = Convert.ToInt32(inputStr1);

			int[] cntArr = new int[3] { 0,0,0};

			int margin = input;
			
			for (int i = 0; i < arr.Length; i++)
			{
				if ( margin >= arr[i])
				{
					cntArr[i] = margin / arr[i];
					margin = margin % arr[i];
				}
			}

			if (margin != 0)
			{
				Console.WriteLine(-1);
			}
			else
			{
				for ( int i = 0; i < cntArr.Length; i++ )
				{
					Console.Write(cntArr[i]);
					if ( i != cntArr.Length - 1 )
						Console.Write(' ');
				}
			}
			
		}
	}
}

