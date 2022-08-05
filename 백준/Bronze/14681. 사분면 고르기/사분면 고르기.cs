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
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }
            if (nums[0] * nums[1] > 0)
                if (nums[0] > 0)
                    Console.WriteLine(1);
                else
                    Console.WriteLine(3);
            else if (nums[0] * nums[1] < 0)
                if (nums[0] > 0)
                    Console.WriteLine(4);
                else
                    Console.WriteLine(2);
        }
    }
}
