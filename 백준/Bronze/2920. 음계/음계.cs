using System;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            string nStr = Console.ReadLine();
            string[] nStrSplit = nStr.Split(' ');
            
            int cnt = 0;



            for (int i = 1; i < nStrSplit.Length; i++)
            {
                int prev = Convert.ToInt32(nStrSplit[i-1]);
                int curr = Convert.ToInt32(nStrSplit[i]);

                if (prev == curr - 1)
                    cnt++;
                else if (prev == curr + 1)
                    cnt--;
            }

            if (cnt == 7)
                Console.WriteLine("ascending");
            else if (cnt == -7)
                Console.WriteLine("descending");
            else
                Console.WriteLine("mixed");
        }
        

    }
}