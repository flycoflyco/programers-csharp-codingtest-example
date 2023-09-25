
using System;


namespace SongE
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string milkMarketStr = Console.ReadLine();
            string[] milkMarketStrSplit = milkMarketStr.Split(' ');
            int result = 0;

            bool strawberryCheck = true;
            bool chocoCheck = false;
            bool bananaCheck = false;

            for ( int i = 0; i < milkMarketStrSplit.Length; i++)
            {
                int market = int.Parse(milkMarketStrSplit[i]);
                if (strawberryCheck)
                {
                    if ( market != 0)
                    {
                        continue;
                    }
                    else
                    {
                        result++;
                        strawberryCheck = false;
                        chocoCheck = true;
                    }
                }
                else if (chocoCheck)
                {
                    if (market != 1)
                    {
                        continue;
                    }
                    else
                    {
                        result++;
                        chocoCheck = false;
                        bananaCheck = true;
                    }
                }
                else if (bananaCheck)
                {
                    if (market != 2)
                    {
                        continue;
                    }
                    else
                    {
                        result++;
                        bananaCheck = false;
                        strawberryCheck = true;
                    }

                }
            }
            Console.WriteLine(result);
        }
    }
}
