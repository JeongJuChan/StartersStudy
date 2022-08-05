using System;
using System.Collections;
using System.Collections.Generic;
namespace BlackJackProject
{

    class Program
    {
        public static void Main(string[] args)
        {
            int[] inputs = new int[10];
            List<int> list = new List<int>();
            for (int i = 0; i < inputs.Length; i++)
            {
                inputs[i] = (int.Parse(Console.ReadLine()) % 42);
            }

            for (int i = 0; i < inputs.Length; i++)
            {
                if (!list.Contains(inputs[i]))
                    list.Add(inputs[i]);
            }

            Console.WriteLine(list.Count);
        }
    }
}
