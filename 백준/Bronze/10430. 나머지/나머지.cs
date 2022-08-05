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
            int[] nums = new int[3];
            for (int i = 0; i < input.Length; i++)
            {
                nums[i] = int.Parse(input[i]);
            }
            //(A + B) % C는((A % C) + (B % C)) % C 와 같을까?
            //(A×B)% C는((A % C) × (B % C)) % C 와 같을까?
            Console.WriteLine((nums[0] + nums[1]) % nums[2]);
            Console.WriteLine(((nums[0] % nums[2]) + (nums[1] % nums[2])) % nums[2]);
            Console.WriteLine((nums[0] * nums[1]) % nums[2]);
            Console.WriteLine(((nums[0] % nums[2]) * (nums[1] % nums[2])) % nums[2]);
        }
    }
}
