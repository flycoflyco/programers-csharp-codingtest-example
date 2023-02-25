using System;

public class Solution {
    public int solution(int[] array) 
    {
        int answer = 0;
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i; j < array.Length; j++)
            {
                if (array[i] > array[j])
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
        }
        int centerIndex = array.Length / 2;
        answer = array[centerIndex];    
        return answer;
    }
}