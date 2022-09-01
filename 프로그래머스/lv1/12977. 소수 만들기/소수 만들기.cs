using System;

class Solution
{
    public int solution(int[] nums)
    {
        int answer = 0;
        int temp = 0;
            for (int i = 0; i < nums.Length - 2; i++)
            {
                for (int j = i + 1; j < nums.Length - 1; j++) 
                {
                    for (int k = j + 1; k < nums.Length; k++)
                    {
                        for (int l = 1; l <= nums[i] + nums[j] + nums[k]; l++)
                        {
                            if ((nums[i] + nums[j] + nums[k]) % l == 0)
                            {
                                temp++;
                            }
                        }
                        if (temp == 2)
                        {
                            answer++;
                        }
                        temp = 0;
                    }
                }
            }
        return answer;
    }
}