using System;
using System.Collections;
using System.Collections.Generic;
namespace BlackJackProject
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split();
            int[] nums = new int[inputs.Length];
            int[] ables = new int[6];
            for (int i = 0; i < inputs.Length; i++)
            {
                nums[i] = int.Parse(inputs[i]);
                ables[nums[i] - 1] += 1;
            }

            int result = 0;
            int max = 0;
            int temp = 0;
            for (int i = 0; i < ables.Length; i++)
            {
                if (max <= ables[i])
                {
                    // 연속 갯수
                    max = ables[i];
                    // 몇 번째
                    temp = i;
                }
            }
            /*
                        같은 눈이 3개가 나오면 10,000원 + (같은 눈)×1,000원의 상금을 받게 된다. 
                        같은 눈이 2개만 나오는 경우에는 1,000원 + (같은 눈)×100원의 상금을 받게 된다. 
                        모두 다른 눈이 나오는 경우에는(그 중 가장 큰 눈)×100원의 상금을 받게 된다.  */
            if (max == 1)
                result = (temp + 1) * 100;
            else if (max == 2)
                result = 1000 + (temp + 1) * 100;
            else
                result = 10000 + (temp + 1) * 1000;
            Console.WriteLine(result);
            
        }
    }
}
