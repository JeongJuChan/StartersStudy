using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution {
    public string solution(string[] survey, int[] choices) {
            // 인덱스 0:R 1:C 2:J 3:A 4:T 5:F 6:M 7:N
            char[] ch = new char[2];
            int[] personallities = new int[8];
            // 성격유형점수는 7개// 0~3번 인덱스 앞에 것 점수 1~3 4번 0점 5~7번 뒤에 것 점수 1~3 
            // 점수 int형으로 내기
            // ["AN", "CF", "MJ", "RT", "NA"]	[5, 3, 2, 7, 5]
            for (int i = 0; i < survey.Length; i++)
            {
                ch = survey[i].ToCharArray();
                if (choices[i] < 4)
                    switch (ch[0])
                    {
                        case 'R':
                            personallities[0] += 4 - choices[i];
                            break;
                        case 'C':
                            personallities[1] += 4 - choices[i];
                            break;
                        case 'J':
                            personallities[2] += 4 - choices[i];
                            break;
                        case 'A':
                            personallities[3] += 4 - choices[i];
                            break;
                        case 'T':
                            personallities[4] += 4 - choices[i];
                            break;
                        case 'F':
                            personallities[5] += 4 - choices[i];
                            break;
                        case 'M':
                            personallities[6] += 4 - choices[i];
                            break;
                        case 'N':
                            personallities[7] += 4 - choices[i];
                            break;
                    }
                else if (choices[i] > 4)
                {
                    switch (ch[1])
                    {
                        case 'R':
                            personallities[0] += choices[i] - 4;
                            break;
                        case 'C':
                            personallities[1] += choices[i] - 4;
                            break;
                        case 'J':
                            personallities[2] += choices[i] - 4;
                            break;
                        case 'A':
                            personallities[3] += choices[i] - 4;
                            break;
                        case 'T':
                            personallities[4] += choices[i] - 4;
                            break;
                        case 'F':
                            personallities[5] += choices[i] - 4;
                            break;
                        case 'M':
                            personallities[6] += choices[i] - 4;
                            break;
                        case 'N':
                            personallities[7] += choices[i] - 4;
                            break;
                    }
                }
            }

            // 큰 값 순으로 정렬
            StringBuilder stringBuilder = new StringBuilder();
            char[] personality = { 'R', 'C', 'J', 'A', 'T', 'F', 'M', 'N' };
            for (int i = 0; i < 4; i++)
            {
                if (personallities[i] >= personallities[i + 4])
                    stringBuilder.Append(personality[i]);
                else
                {
                    stringBuilder.Append(personality[i + 4]);
                }
            }
            return stringBuilder.ToString();
    }
}