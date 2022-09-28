using System.Collections.Generic;
public class Solution {
    public string solution(int n) {
        List<char> answer = new List<char>();
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    answer.Add('수');
                }
                else
                {
                    answer.Add('박');
                }
            }
        return new string(answer.ToArray());
    }
}