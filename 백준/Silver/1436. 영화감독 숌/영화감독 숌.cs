using System;

namespace BlackJackProject
{

    class Program
    {
        // 첫 번째 줄은 어떻게 정할 것인가?
        // 첫 번째 줄이 정해졌다면 그 하위의 줄들은 모양이 정해짐 - 반대
        public static void Main(string[] args)
        {
            // % 6 60 600 6000 ... == 0 연속 3개
            int num = 666;
            int comp = 666;
            int mode = 1;
            string input = Console.ReadLine();
            string temp = "";
            int iInput = int.Parse(input);
            int count = 0;
            while (true)
            {
                // num에 연속한 666이 있으면
                temp = (comp * mode).ToString();
                if (num.ToString().Contains(temp))
                    count++;
                if (count == iInput)
                    break;
                num++;
            }

            Console.WriteLine(num);
        }
    }
}
