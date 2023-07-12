using System;
using System.Collections.Generic;

namespace ConsoleApp34
{
	public class Program
	{
		public static void Main()
		{
			string inputStr = Console.ReadLine();
			string[] inputStrSplit = inputStr.Split(' ');
			int n = Convert.ToInt32(inputStrSplit[0]);
			long w = Convert.ToInt64(inputStrSplit[1]);

			long[] pricefordayArr = new long[n];
			for ( int i = 0; i < pricefordayArr.Length; i++)
			{
				string priceStr = Console.ReadLine();
				long price = Convert.ToInt64(priceStr);
				pricefordayArr[i] = price;
			}

			// int currPrice = pricefordayArr[0];
			long myMoney = w;
			long myByteCoin = 0;
			long buyPrice = 0;

			for ( int i = 0; i < pricefordayArr.Length-1; i++)
			{
				long currPrice = pricefordayArr[i];
				long tomorrowPrice = pricefordayArr[i+1];



				if (currPrice > tomorrowPrice)
				{
					// 가격이 내려가는 중
					// 사고 팔기 안하기
					if (buyPrice != 0)
					{
						// 살가격이 있고, 내일 내려간다고 가정했을 때,

						// 이전 살 가격으로 사고
						myByteCoin = myMoney / buyPrice;
						myMoney = myMoney % buyPrice;

						// 오늘 팔 가격으로 팔기
						myMoney += (currPrice * myByteCoin);
						myByteCoin = 0;
						buyPrice = 0;
					}
					
				}
				else if (currPrice == tomorrowPrice)
				{
					// 이전가격과 같을 경우 보류, 하지만 마지막인 경우 판다
					if (i == pricefordayArr.Length - 2 && buyPrice != 0)
					{
						myByteCoin = myMoney / buyPrice;
						myMoney = myMoney % buyPrice;

						// 내일 가격으로 팔기
						myMoney += (tomorrowPrice * myByteCoin);
						myByteCoin = 0;
					}
				}
				else if (currPrice < tomorrowPrice)
				{
					// 사고팔 준비
					// 오늘 가격을 넣어놓고, 최고까지 갈때 팔기 위해 살가격 저장
					if (buyPrice == 0)
					{
						buyPrice = currPrice;
						// 살 가격 저장 했는데 마지막인 경우
						if (i == pricefordayArr.Length - 2)
						{
							myByteCoin = myMoney / buyPrice;
							myMoney = myMoney % buyPrice;

							// 내일 가격으로 팔기
							myMoney += (tomorrowPrice * myByteCoin);
							myByteCoin = 0;
						}
					}
					else if (buyPrice != 0 && i == pricefordayArr.Length - 2)
					{
						myByteCoin = myMoney / buyPrice;
						myMoney = myMoney % buyPrice;

						// 내일 가격으로 팔기
						myMoney += (tomorrowPrice * myByteCoin);
						myByteCoin = 0;
					}
				}
			}

			Console.WriteLine(myMoney);


		}

	}
}