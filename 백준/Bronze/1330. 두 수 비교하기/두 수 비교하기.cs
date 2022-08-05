using System;
using System.Collections;
using System.Collections.Generic;
namespace BlackJackProject
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int[] nums = new int[2];
            for (int i = 0; i < input.Length; i++)
                nums[i] = int.Parse(input[i]);
            if (nums[0] > nums[1])
                Console.WriteLine(">");
            else if (nums[0] < nums[1])
                Console.WriteLine("<");
            else 
                Console.WriteLine("==");
        }
    }
}
