using System;

class Solution
{
    public int solution(int n)
    {
			//string nmStr = Console.ReadLine();
			//int n = Convert.ToInt32(nmStr); // n 이동할 거리
			int k = 0;
			while (n > 0)
			{
				if (n % 2 == 0)
				{
					n = n / 2;
				}
				else
				{
					n--;
					k++;
				}
			}

			return k;
    }
}