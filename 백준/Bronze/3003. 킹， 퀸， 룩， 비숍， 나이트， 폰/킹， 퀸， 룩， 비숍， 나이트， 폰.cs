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
            int[] checkNums = new int[] { 1, 1, 2, 2, 2, 8 };
            for (int i = 0; i < inputs.Length; i++)
            {
                nums[i] = int.Parse(inputs[i]);
            }

            int[] results = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != checkNums[i])
                    results[i] = checkNums[i] - nums[i];
            }
            for (int i = 0; i < results.Length; i++)
            {
                Console.Write(results[i] + " ");
            }
        }
    }
}
