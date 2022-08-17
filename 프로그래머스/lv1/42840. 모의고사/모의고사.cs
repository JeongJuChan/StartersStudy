using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int[] answers)
    {
        int[] answer = new int[3] { 1, 2, 3 };
        int[] counts = new int[answer.Length];
        int[] su1 = new int[] { 1, 2, 3, 4, 5 };
        int[] su2 = new int[] { 2, 1, 2, 3, 2, 4, 2, 5, 2, 1, 2, 3, 2, 4, 2, 5 };
        int[] su3 = new int[] { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 };
        int count = 0;
        // 
        
        for (int i = 0; i < answers.Length; i++)
        {
            if (answers[i] == su1[i % 5])
            {
                counts[0]++;
            }
        }

        for (int i = 0; i < answers.Length; i++)
        {
            if (answers[i] == su2[i % 16])
            {
                counts[1]++;
            }
        }

        for (int i = 0; i < answers.Length; i++)
        {
            if (answers[i] == su3[i % 10])
            {
                counts[2]++;
            }
        }

        int max = 0;
        List<int> list = new List<int>();
        for (int i = 0; i < answer.Length; i++)
        {
            if (max < counts[i])
            {
                max = counts[i];
                if (list.Count > 0)
                    list.Clear();
                list.Add(answer[i]);
            }
            else if (max == counts[i])
            {
                list.Add(answer[i]);
            }
        }
        list.Sort();
        
        // answer는 가장 많은 점수를 받은 사람
        // 동점 여러명일 시 오름차순
        return list.ToArray();
    }
}