using System;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            string numStr = Console.ReadLine();
            string[] numStrSplit = numStr.Split(' ');
            int bugerNum = Convert.ToInt32(numStrSplit[0]);
            int sideNum = Convert.ToInt32(numStrSplit[1]);
            int drinkNum = Convert.ToInt32(numStrSplit[2]);

            string bugerPriceStr = Console.ReadLine();
            string[] bugerPriceStrSplit = bugerPriceStr.Split(' ');
            int[] bugerPrice = Array.ConvertAll(bugerPriceStrSplit, new Converter<string, int>(StringToInt));
            Array.Sort(bugerPrice);
            Array.Reverse(bugerPrice);

            string sidePriceStr = Console.ReadLine();
            string[] sidePriceStrSplit = sidePriceStr.Split(' ');
            int[] sidePrice = Array.ConvertAll(sidePriceStrSplit, new Converter<string, int>(StringToInt));
            Array.Sort(sidePrice);
            Array.Reverse(sidePrice);

            string drinkPriceStr = Console.ReadLine();
            string[] drinkPriceStrSplit = drinkPriceStr.Split(' ');
            int[] drinkPrice = Array.ConvertAll(drinkPriceStrSplit, new Converter<string, int>(StringToInt));
            Array.Sort(drinkPrice);
            Array.Reverse(drinkPrice);

            int maxNum = 0;

            if (bugerNum > sideNum)
            {
                if (bugerNum > drinkNum)
                    maxNum = bugerNum;
                else
                    maxNum = drinkNum;
            }
            else
            {
                if (sideNum > drinkNum)
                    maxNum = sideNum;
                else
                    maxNum = drinkNum;
            }


            double salePrice = 0;
            int price = 0;

            for (int i = 0; i < maxNum; i++)
            {
                if (i < bugerNum && i < sideNum && i < drinkNum)
                {
                    price += (bugerPrice[i] + sidePrice[i] + drinkPrice[i]);
                    salePrice += (bugerPrice[i] + sidePrice[i] + drinkPrice[i]) * 0.9;
                }
                else
                {
                    if (i < bugerNum)
                    {
                        price += bugerPrice[i];
                        salePrice += bugerPrice[i];
                    }

                    if (i < sideNum)
                    {
                        price += sidePrice[i];
                        salePrice += sidePrice[i];
                    }

                    if (i < drinkNum)
                    {
                        price += drinkPrice[i];
                        salePrice += drinkPrice[i];
                    }
                }
            }
            Console.WriteLine(price);
            Console.WriteLine(salePrice);


        }

        public static int StringToInt(string item) => int.Parse(item);
    }
}