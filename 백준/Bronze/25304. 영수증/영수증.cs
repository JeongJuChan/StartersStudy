using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string sumStr = Console.ReadLine();
            string numStr = Console.ReadLine();
            int sum = 0;
            int temp = 1;
            int[] numArr = new int[2];
            for (int i = 0; i < int.Parse(numStr); i++)
            {
                string[] str = Console.ReadLine().Split();
                for (int j = 0; j < numArr.Length; j++)
                {
                    numArr[j] = int.Parse(str[j]);
                    temp *= numArr[j];
                }
                sum += temp;
                temp = 1;
            }
            int sumOrg = int.Parse(sumStr);
            if (sumOrg == sum)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}
