using System;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            long result = 0;

            #region Input
            string abcStr = Console.ReadLine();
            string[] abcStrSplit = abcStr.Split(' ');
            long a = Convert.ToInt32(abcStrSplit[0]);
            long b = Convert.ToInt32(abcStrSplit[1]);
            long c = Convert.ToInt32(abcStrSplit[2]);
            string xyzStr = Console.ReadLine();
            string[] xyzStrSplit = xyzStr.Split(' ');
            long x = Convert.ToInt32(xyzStrSplit[0]);
            long y = Convert.ToInt32(xyzStrSplit[1]);
            long z = Convert.ToInt32(xyzStrSplit[2]);
            #endregion

            // 먼저 먹고싶은 사람과 쿠폰 정리
            result += SetCupon(ref a, ref x);
            result += SetCupon(ref b, ref y);
            result += SetCupon(ref c, ref z);

            // 나머지 쿠폰으로 돌리고 돌리고

            // 3x 쿠폰 교환
            result += ThreeCupon(ref b, ref x);
            result += ThreeCupon(ref c, ref y);
            result += ThreeCupon(ref a, ref z);

            // 9x 쿠폰 교환
            result += NineCupon(ref c, ref x);
            result += NineCupon(ref a, ref y);
            result += NineCupon(ref b, ref z);

            Console.WriteLine(result);
        }


        private static long NineCupon(ref long c, ref long x)
        {
            long result = 0;
            if (x > 9 && c > 0)
            {
                if (9 * c > x)
                {
                    long mok = x / 9;
                    x = x - (9 * mok);
                    c = c - mok;
                    result = mok;
                }
                else if (9 * c == x)
                {
                    result = c;
                    c = 0;
                    x = 0;
                }
                else
                {
                    x = x - (9 * c);
                    result = c;
                    c = 0;
                }
            }
            return result;
        }

        private static long ThreeCupon(ref long b, ref long x)
        {
            long result = 0;
            if (x > 3 && b > 0)
            {
                if (3 * b > x)
                {
                    long mok = x / 3;
                    x = x - (3 * mok);
                    b = b - mok;
                    result = mok;
                }
                else if (3 * b == x)
                {
                    result = b;
                    b = 0;
                    x = 0;
                }
                else
                {
                    x = x - (3 * b);
                    result = b;
                    b = 0;
                }
            }
            return result;
        }

        private static long SetCupon(ref long a, ref long x)
        {
            long result = 0;
            if (a > x)
            {
                a = a - x;
                result = x;
                x = 0;
            }
            else if (a == x)
            {
                a = 0;
                result = x; // a도 상관 없음
                x = 0;
            }
            else
            {
                x = x - a;
                result = a;
                a = 0;
            }
            return result;
        }
    }
}