using System;
using System.Collections;
using System.Collections.Generic;
namespace BlackJackProject
{
    class Program
    {
        public static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            for (int i = 1; i < 10; i++)
                Console.WriteLine(input + " * " + i + " = " + input * i);
        }
    }
}
