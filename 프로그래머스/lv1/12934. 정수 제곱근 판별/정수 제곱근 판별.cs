using System;
public class Solution {
    public long solution(long n) {
        long answer = 0;
            double num;
            num = Math.Sqrt(n);
            if (num % 1 == 0)
            {
                answer = (long)Math.Pow(num + 1, 2);
            }
        else
        {
            answer = -1;
        }
        return answer;
    }
}