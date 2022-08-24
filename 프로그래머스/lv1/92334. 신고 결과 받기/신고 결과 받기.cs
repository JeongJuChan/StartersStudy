using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int[] solution(string[] id_list, string[] report, int k) {
            int[] reports = new int[id_list.Length];
            int[] suspension = new int[id_list.Length];
            string[] split = new string[2];
            List<string> reporter = new List<string>();
            List<string> suspensed = new List<string>();
            // 1번방은 ?? -> muzi 2번방은 ?? -> frodo

            report = report.Distinct().ToArray();
            
            for (int i = 0; i < report.Length; i++)
            {
                split = report[i].Split();
                reporter.Add(split[0]);
                suspensed.Add(split[1]);
            }

            for (int i = 0; i < id_list.Length; i++)
            {
                for (int j = 0; j < report.Length; j++)
                {
                    
                    if (suspensed[j] == id_list[i])
                    {
                        suspension[i]++;
                    }
                }
            }
            for (int i = 0; i < suspension.Length; i++)
            {
                if (suspension[i] >= k)
                {
                    for (int j = 0; j < report.Length; j++)
                    {
                        if (suspensed[j] == id_list[i])
                        {
                            for (int l = 0; l < reports.Length; l++)
                            {
                                if (id_list[l] == reporter[j])
                                {
                                    reports[l]++;
                                }
                            }       
                        }
                    }
                }    
            }
            
            return reports;
    }
}