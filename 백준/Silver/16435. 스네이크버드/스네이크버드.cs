using System;


namespace ConsoleApp34
{
	public class Program
	{
		public static void Main()
		{
			string inputStr = Console.ReadLine();
			string[] inputSplit = inputStr.Split(' ');

			int numCnt = Convert.ToInt32(inputSplit[0]);
			int length = Convert.ToInt32(inputSplit[1]);

			string frNumStr = Console.ReadLine();
			string[] frNumSplit = frNumStr.Split(' ');

			int[] arr = new int[numCnt];
			for ( int i = 0; i < numCnt; i++)
			{
				arr[i] = Convert.ToInt32(frNumSplit[i]);
			}

			bool noneflag = false;

			int index = 0;
			while (true)
			{
				if ( arr[index] <= length && arr[index] != -1)
				{
					length++;
					noneflag = true;
					arr[index] = -1;
				}
				index++;
				if (index == arr.Length)
				{
					index = 0;
					if (!noneflag)
						break;
					noneflag = false;
				}
			}

			Console.WriteLine(length);

		}

	}
}


