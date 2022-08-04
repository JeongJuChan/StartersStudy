using System;

namespace BlackJackProject
{

    class Program
    {
        public static void Main(string[] args)
        {
            // 입력 받기
            string str = Console.ReadLine();
            int n = int.Parse(str);
            int[,] go = new int[n, 2];

            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split();
                for (int j = 0; j < 2; j++)
                {
                    go[i, j] = int.Parse(s[j]);
                }
            }
            /*5
        0    55 0,0     185 0,1
        1    58 1,0     183 1,1
        2    88 2,0     186 2,1
        3    60 3,0     175 3,1
        4    46 4,0     155 4,1*/
            int[] grade = new int[n];
            // 덩치 계산하기
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (go[i, 0] < go[j, 0] && go[i, 1] < go[j, 1])
                        grade[i] += 1;
                }
            }
            // 비교 
            
            for (int i = 0; i < grade.Length; i++)
            {
                grade[i]++;
                Console.Write(grade[i] + " ");
            }
        }
    }
}
