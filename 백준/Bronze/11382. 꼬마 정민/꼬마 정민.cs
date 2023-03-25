using System;


namespace Programers_codetest_example
{
	internal class Program
	{
        public static void Main()
		{
            string input = Console.ReadLine();
            string[] values = input.Split(' ');
            long sum = 0;
            for ( int i = 0; i < values.Length; i++)
			{
                sum += Convert.ToInt64(values[i]);
			}
            Console.WriteLine(sum);
        }
    }
}