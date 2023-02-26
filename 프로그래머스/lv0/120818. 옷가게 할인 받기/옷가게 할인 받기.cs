using System;

public class Solution {
    public int solution(int price) 
    {
			int answer = price;
			double temp = 0;
			if (100000 <= price && price < 300000)
			{
				temp = (double)price *0.95;
				answer = (int)temp;
			}
			else if (300000 <= price  && price < 500000)
			{
				temp = (double)price * 0.9;
				answer = (int)temp;
			}
			else if (price >= 500000)
			{
				temp = (double)price * 0.8;
				answer = (int)temp;
			}

			return answer;
    }
}