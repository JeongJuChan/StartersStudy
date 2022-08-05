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
            int input = int.Parse(Console.ReadLine());
            int[] nums = new int[2];
            int[] cookTimes = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = int.Parse(inputs[i]);
            }

            cookTimes[0] = input / 60;
            cookTimes[1] = input % 60;

            if ((nums[1] + cookTimes[1]) >= 60)
            {
                cookTimes[0]++;
                nums[1] = (nums[1] + cookTimes[1]) % 60;
            }
            else
                nums[1] = nums[1] + cookTimes[1];

            if ((nums[0] + cookTimes[0]) >= 24)
            {
                nums[0] = (nums[0] + cookTimes[0]) % 24;
            }
            else
                nums[0] = nums[0] + cookTimes[0];

            for (int i = 0; i < nums.Length; i++)
                Console.Write(nums[i] + " ");
        }
    }
}
