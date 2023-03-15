using System;


public class Solution {
    public long solution(int a, int b) {
            long answer = 0;
            if (a > 10000000 || a < -10000000)
            {
                return answer;
            }
            if (b > 10000000 || b < -10000000)
            {
                return answer;
            }
            if (a == b)
            {
                return (long)a;
            }
            else
            {
                if (a > b)
                {
                    int temp = a;
                    a = b;
                    b = temp;
                }
            }
            long cnt = (b - a) + 1;
            long aLong = (long)a;
            long bLong = (long)b;
            answer = (cnt * (aLong + bLong)) / 2;
            return answer;
    }
    
}