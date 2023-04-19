using System;

namespace ConsoleApp34
{
	public class Program
	{
		public static void Main()
		{
			string inputStr1 = Console.ReadLine();
			string[] inputSplit1 = inputStr1.Split(' ');
			int cardNum = Convert.ToInt32(inputSplit1[0]);
			int perporseNum = Convert.ToInt32(inputSplit1[1]);


			string inputStr2 = Console.ReadLine();
			string[] inputSplit2 = inputStr2.Split(' ');
			int[] cardArr = new int[inputSplit2.Length];


			for ( int i = 0; i < inputSplit2.Length; i++)
			{
				cardArr[i] = Convert.ToInt32(inputSplit2[i]);
			}

			int min = int.MaxValue;
			int value = 0;

			for ( int i = 0; i < cardArr.Length; i++)
			{
				for ( int j = i+1; j < cardArr.Length; j++)
				{
					for ( int k = j+1; k < cardArr.Length; k++)
					{
						int temp = perporseNum - (cardArr[i] + cardArr[j] + cardArr[k]);
						if ( temp >= 0)
						{
							if ( min > temp )
							{
								min = temp;
								value = (cardArr[i] + cardArr[j] + cardArr[k]);
							}
						}
					}
				}
			}

			Console.WriteLine(value);






		}
	}
}

