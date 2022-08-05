using System;
using System.Collections;
using System.Collections.Generic;
namespace BlackJackProject
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] input = new string[2];
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = Console.ReadLine();
            }
            int[] nums = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = int.Parse(input[i]);
            }

            int num = nums[1];
            Console.WriteLine(nums[0] * (nums[1] % 10));
            Console.WriteLine(nums[0] * ((nums[1] % 100) / 10));
            Console.WriteLine(nums[0] * (nums[1] / 100));
            int result = nums[0] * (nums[1] % 10) + (nums[0] * ((nums[1] % 100) / 10)) * 10 + (nums[0] * (nums[1] / 100)) * 100;
            Console.WriteLine(result);
        }
    }
}
