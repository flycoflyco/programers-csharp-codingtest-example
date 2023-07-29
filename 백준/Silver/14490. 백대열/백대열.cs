using System;


namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            string inputStr = Console.ReadLine();
            string[] inputStrSplit = inputStr.Split(':');
            int n = Convert.ToInt32(inputStrSplit[0]);
            int m = Convert.ToInt32(inputStrSplit[1]);

            int temp = Euclidean(n, m);

            if ( temp != 1)
            {
                n = n / temp;
                m = m / temp;
            }

            Console.WriteLine(n + ":" + m);
        }

        private static int Euclidean(int a, int b)
        {
            int r = a % b;
            if (r == 0)
            {
                return b;
            }
            return Euclidean(b, r);
        }
    }
}
