using System;

namespace BlackJackProject
{
    class Program
    {
        public static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int result = 0;
            for (int i = 1; i <= input; i++)
            {
                result += i;
            }
            Console.WriteLine(result);
        }
    }
}
