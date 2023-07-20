using System;
namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            string wantCatNumStr = Console.ReadLine();
            ulong wantCatNum = Convert.ToUInt64(wantCatNumStr);
            ulong catNum = 0;
            int result = 0;
            while (catNum != wantCatNum)
            {
                if (catNum == 0)
                {
                    catNum++;
                }
                else
                {
                    if (catNum * 2 < wantCatNum)
                    {
                        catNum *= 2;
                    }
                    else
                    {
                        result++;
                        break;
                    }
                }
                result++;
            }

            Console.WriteLine(result);
        }
    }
}