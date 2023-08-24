using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            List<int> nums = new List<int>();
            //int sum = 0;

            int[] frequency = new int[8001];
            for (int i = 0; i < num; i++)
            {
                int inputNum = int.Parse(Console.ReadLine());
                if (inputNum < 0)
                {

                    frequency[4000 + Math.Abs(inputNum)]++;
                }
                else
                {
                    frequency[inputNum]++;
                }
                nums.Add(inputNum);
            }
            nums.Sort();
            // 평균
            Console.WriteLine(Convert.ToInt32(nums.Average()));

            // 중앙값
            if (num - 1 < 1)
            {
                Console.WriteLine(nums[0]);
            }
            else
            {
                int index = (num - 1) / 2;
                Console.WriteLine(nums[index]);
            }

            int max = int.MinValue;
            int maxindex = int.MinValue;
            for (int i = 0; i < 8001; i++)
            {
                int s = frequency[i];
                if (max < s)
                {
                    max = s;
                    maxindex = i;
                }
            }

            List<int> maxfrequencies = new List<int>();

            for (int i = 0; i < 8001; i++)
            {
                if (max == frequency[i])
                {
                    if (i > 4000)
                        maxfrequencies.Add(4000 - i);
                    else
                        maxfrequencies.Add(i);
                }
            }

            
            int maxFrequency = 0;

            if (maxfrequencies.Count == 1)
            {
                maxFrequency = maxfrequencies[0];
            }
            else if (maxfrequencies.Count > 1)
            {
                maxfrequencies.Sort();
                maxFrequency = maxfrequencies[1];
            }

            // 최빈값
            Console.WriteLine(maxFrequency);

            // 최대 - 최소
            Console.WriteLine(nums[nums.Count - 1] - nums[0]);
        }

    }
}