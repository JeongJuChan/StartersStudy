using System;

public class Solution
{
    public int solution(int[] numbers)
    {
        int result = 0;
        for (int i = 0; i < 10; i++)
        {
            result += i;
        }
        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                if (numbers[i] == j)
                    result -= j;
            }
        }
        Console.WriteLine(result);
        return result;
    }
}