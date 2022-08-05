using System;
using System.Collections;
using System.Collections.Generic;
namespace BlackJackProject
{
    class Program
    {
        public static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int score = int.Parse(str);
            int result = 0;
            if (score <= 100 && score >= 90)
                Console.WriteLine("A");
            else if (score < 90 && score >= 80)
                Console.WriteLine("B");
            else if (score < 80 && score >= 70)
                Console.WriteLine("C");
            else if (score < 70 && score >= 60)
                Console.WriteLine("D");
            else
                Console.WriteLine("F");
        }
    }
}
