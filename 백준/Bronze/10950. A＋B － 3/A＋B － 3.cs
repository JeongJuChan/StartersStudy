using System;
using System.Collections;
using System.Collections.Generic;
namespace BlackJackProject
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] nums = new int[2]; 
            int caseNum = int.Parse(Console.ReadLine());
            for (int i = 0; i < caseNum; i++)
            {
                string[] inputs = Console.ReadLine().Split();
                for (int j = 0; j < inputs.Length; j++)
                {
                    nums[j] = int.Parse(inputs[j]);
                }
                Console.WriteLine(nums[0] + nums[1]);
            }
        }
    }
}
