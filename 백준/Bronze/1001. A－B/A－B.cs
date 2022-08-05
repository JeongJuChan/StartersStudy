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
            int[] num = new int[2];
            for (int i = 0; i < input.Length; i++)
            {
                num[i]= int.Parse(input[i]);
            }
            Console.WriteLine(num[0] - num[1]);
        }
    }
}
