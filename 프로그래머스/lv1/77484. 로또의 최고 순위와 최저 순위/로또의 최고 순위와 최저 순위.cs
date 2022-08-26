using System;

public class Solution {
    public int[] solution(int[] lottos, int[] win_nums) {
            int[] answer = new int[] { 7, 7 };
            int isZero = 0;
            for (int i = 0; i < lottos.Length; i++)
            {
                for (int j = 0; j < win_nums.Length; j++)
                {
                    if (lottos[i].Equals(win_nums[j]))
                    {
                        answer[1]--;
                    }
                }

                if (lottos[i].Equals(0))
                    isZero++;
            }
            if (answer[1] == 7)
                answer[1] = 6;
            answer[0] = answer[1];
            answer[0] -= isZero;
            
            
            if (answer[1] < 1)
            {
                answer[1] = 1;
            }
        
            if (answer[0] < 1)
            {
                answer[0] = 1;
            }
        return answer;
    }
}