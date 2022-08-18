using System;

public class Solution {
    public int[] solution(string[,] places) {
        char[] charArr = new char[5];
            char[,] charArr2 = new char[5,5];
            int[] answer = new int[5];
            for (int i = 0; i < answer.Length; i++)
            {
                answer[i] = 1;
            }
            for (int i = 0; i < places.GetLength(0); i++)
            {
                for (int j = 0; j < places.GetLength(1); j++)
                {
                    charArr = places[i,j].ToCharArray();
                    for (int k = 0; k < charArr.Length; k++)
                    {
                        charArr2[j, k] = charArr[k];
                    }
                }
                for (int k = 0; k < charArr2.GetLength(0); k++)
                {
                    // 안 되는 경우만 찾기
                    for (int l = 0; l < charArr2.GetLength(1); l++)
                    {
                        if (charArr2[k, l] == 'P')
                        {
                            // 가로
                            if (l < 4)
                            {
                                if (charArr2[k, l + 1] == 'P')
                                {
                                    answer[i] = 0;
                                    break;
                                }
                                if (l < 3)
                                {
                                    if (charArr2[k, l + 2] == 'P')
                                    {
                                        if (charArr2[k, l + 1] != 'X')
                                        {
                                            answer[i] = 0;
                                            break;
                                        }
                                    }
                                }
                                // 우아래 대각선
                                if (k < 4)
                                {
                                    if (charArr2[k + 1, l + 1] == 'P')
                                    {
                                        if (charArr2[k + 1, l] != 'X' || charArr2[k, l + 1] != 'X')
                                        {
                                            answer[i] = 0;
                                            break;
                                        }
                                    }
                                }
                            }
                            // 세로
                            if (k < 4)
                            {
                                if (charArr2[k + 1, l] == 'P')
                                {
                                    answer[i] = 0;
                                    break;
                                }
                                if (k < 3)
                                {
                                    if (charArr2[k + 2, l] == 'P')
                                    {
                                        if (charArr2[k + 1, l] != 'X')
                                        {
                                            answer[i] = 0;
                                            break;
                                        }
                                    }
                                }
                                // 좌아래 대각선
                                if (l > 0)
                                {
                                    if (charArr2[k + 1, l - 1] == 'P')
                                    {
                                        if (charArr2[k + 1, l] != 'X' || charArr2[k, l - 1] != 'X')
                                        {
                                            answer[i] = 0;
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        return answer;
    }
}