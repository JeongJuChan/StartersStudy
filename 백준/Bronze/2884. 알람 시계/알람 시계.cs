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
            int[] nums = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = int.Parse(inputs[i]);
            }
            if (nums[1] < 45)
            {
                if (nums[0] < 1)
                    nums[0] = 23;
                else
                {
                    nums[0]--;
                }
                nums[1] += 15;
            }
            else
            {
                nums[1] -= 45;
            }

            for (int i = 0; i < nums.Length; i++)
                Console.Write(nums[i] + " ");
        }
    }
}
