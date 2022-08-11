using System;

namespace BlackJackProject
{

    class Program
    {
        // 첫 번째 줄은 어떻게 정할 것인가?
        // 첫 번째 줄이 정해졌다면 그 하위의 줄들은 모양이 정해짐 - 반대
        public static void Main(string[] args)
        {
            // 몇개 받을 지 입력
            string[] inputs = Console.ReadLine().Split();
            // 몇개 받을 지 공간
            int[] nums = new int[2];
            for (int i = 0; i < inputs.Length; i++)
            {
                nums[i] = int.Parse(inputs[i]);
            }
            
            char[,] charArr = new char[nums[0],nums[1]];
            
            // 배열 두 개를 만들어 놓고 완성될 모양을 넣어 놓는다.
            // j에서 실행될 때 각 배열이 서로 다르게 그 모양을 넣고 이후 1줄이 끝날 때 비교한다.
            char[,] compareArr1 = new char[8, 8];
            char[,] compareArr2 = new char[8, 8];

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    // 짝수 BWBWBWBW
                    if (i % 2 == 0)
                    {
                        if (j % 2 == 0)
                            compareArr1[i, j] = 'B';
                        else
                            compareArr1[i, j] = 'W';
                    }
                    // 홀수 WBWBWBWB
                    else
                    {
                        if (j % 2 == 1)
                            compareArr1[i, j] = 'B';
                        else
                            compareArr1[i, j] = 'W';
                    }
                }
            }

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    // 짝수 BWBWBWBW
                    if (i % 2 == 0)
                    {
                        if (j % 2 == 0)
                            compareArr2[i, j] = 'W';
                        else
                            compareArr2[i, j] = 'B';
                    }
                    // 홀수 WBWBWBWB
                    else
                    {
                        if (j % 2 == 1)
                            compareArr2[i, j] = 'W';
                        else
                            compareArr2[i, j] = 'B';
                    }
                }
            }

            // 인풋 받아서 넣기 (x/y 타일)
            for (int i = 0; i < charArr.GetLength(0); i++)
            {
                string[] inputArr = Console.ReadLine().Split();
                for (int j = 0; j < charArr.GetLength(1); j++)
                {
                    charArr[i, j] = inputArr[0].ToCharArray()[j];
                }
            }
            // 8 검사
            int minCount = 0;
            int count = 0;
            for (int i = 0; i <= charArr.GetLength(0) - 8; i++)
            {
                for (int j = 0; j <= charArr.GetLength(1) - 8; j++)
                {
                    // 돌리기
                    for (int k = 0; k < 8; k++)
                    {
                        for (int l = 0; l < 8; l++)
                        {
                            if (charArr[k+ i, l + j] != compareArr1[k, l])
                            {
                                count++;
                            }
                        }
                    }
                    
                    if (i == 0 && j == 0)
                        minCount = count;
                    if (minCount > count)
                        minCount = count;
                    count = 0;
                    for (int k = 0; k < 8; k++)
                    {
                        for (int l = 0; l < 8; l++)
                        {
                            if (charArr[k + i, l + j] != compareArr2[k, l])
                            {
                                count++;
                            }
                        }
                    }
                    if (minCount > count)
                        minCount = count;
                    count = 0;
                }
            }
            Console.WriteLine(minCount);
        }
    }
}
