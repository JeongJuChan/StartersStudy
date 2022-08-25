using System;

public class Solution {
    public int solution(int[,] sizes) {
       int maxRow = 0;
            int rowIndex = 0;
            int maxHeight = 0;
            int heightIndex = 0;
            for (int i = 0; i < sizes.GetLength(0); i++)
            {
                if (maxRow < sizes[i, 0])
                {
                    maxRow = sizes[i, 0];
                    rowIndex = i;
                }
                if (maxHeight < sizes[i, 1])
                {
                    maxHeight = sizes[i, 1];
                    heightIndex = i;
                }
            }
            int minMax = 0;
            int answer = 0;
            if (maxRow >= maxHeight)
            {
                minMax = sizes[rowIndex, 1];
                for (int i = 0; i < sizes.GetLength(0); i++)
                {
                    if (i == rowIndex)
                        continue;
                    //[60, 50], [30, 70], [60, 30], [80, 40]
                    if (minMax < sizes[i, 1])
                    {
                        if (sizes[i, 0] > sizes[i, 1])
                        {
                            minMax = sizes[i, 1];
                        }
                        else
                        {
                            if (minMax < sizes[i, 0])
                            {
                                minMax = sizes[i, 0];
                            }
                        }
                    }
                }
                answer = maxRow * minMax;
            }
            else
            {
            /*int[,] sizes = new int[,] {[7, 10], [3, 12], [8, 15], [14, 7], [5, 15]};*/
                minMax = sizes[heightIndex, 0];
                for (int i = 0; i < sizes.GetLength(0); i++)
                {
                    if (i == heightIndex)
                        continue;
                    if (minMax < sizes[i, 0])
                    {
                        if (sizes[i, 0] < sizes[i, 1])
                        {
                            minMax = sizes[i, 0];
                        }
                        else
                        {
                            if (minMax < sizes[i, 1])
                            {
                                minMax = sizes[i, 1];
                            }
                        }
                    }
                    /*if (sizes[i, 0] > minMax)
                    {
                        if (sizes[i, 0] < sizes[i, 1])
                        {
                            minMax = sizes[i, 0];
                        }
                    }*/
                    /*else
                    {
                        if (sizes[i, 1] > minMax)
                        {
                            minMax = sizes[i, 1];
                        }
                    }*/
                }
                answer = maxHeight * minMax;
            }
        return answer;
    }
}