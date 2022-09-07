using System;

public class Solution {
    public int solution(int n) {
        string num = "";
            while (n > 0)
            {
                num += n % 3;
                n = n / 3;
            }

            Console.WriteLine(num);
            
            int j = 1;
            int answer = 0;
            for (int i = num.Length - 1; i >= 0; i--)
            {
                answer += j * Convert.ToInt32(num[i].ToString());
                j *= 3;
            }
        return answer;
    }
}