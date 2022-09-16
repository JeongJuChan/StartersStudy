using System;
public class Solution {
    public long solution(long n) {
        long answer = 0;
            double i = 1;
            while (true)
            {
                double temp = Math.Pow(i, 2);
                if (temp > n)
                {
                    answer = -1;
                    break;
                }

                if (n == temp)
                {
                    temp = Math.Pow(i+1, 2);
                    answer = (long)temp;
                    break;
                }
                i++;
            }
        return answer;
    }
}