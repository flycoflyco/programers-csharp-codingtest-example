using System;

namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {
            string innputStr = Console.ReadLine();
            int inputNum = Convert.ToInt32(innputStr);
            int currNum = inputNum;
            int count = 0;
            do
            {
                int frontNum = currNum / 10;
                int backNum = currNum % 10;

                int newNum = (frontNum + backNum) % 10;

                currNum = (backNum * 10) + (newNum);

                count++;
            } while (inputNum != currNum);
            Console.WriteLine(count);
        }
    }
}
