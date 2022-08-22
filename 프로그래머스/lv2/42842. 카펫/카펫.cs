using System;

public class Solution {
    public int[] solution(int brown, int yellow) {
        int[] answer = new int[2];
        for (int i = 1; i <= yellow; i++)
            {
                for (int j = 1; j <= yellow / i; j++)
                {
                    if (i * j == yellow)
                    {
                        if (brown == 2 * i + 2 * j + 4)
                        {
                            if (i >= j)
                            {
                                answer[0] = i+2;
                                answer[1] = j+2;
                                break;
                            }
                        }
                    }
                }
            }
        return answer;
    }
}