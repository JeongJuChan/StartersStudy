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
            int[] ints = new int[input.Length];
            int result = 0;
            for (int i = 0; i < input.Length; i++)
            {
                ints[i] = int.Parse(input[i]);
                result += ints[i];
            }
            Console.WriteLine(result);
        }
    }
}
