using System;

public class Example
{
    public static void Main()
    {
        string[] s = Console.ReadLine().Split();
            int a = Int32.Parse(s[0]);
            int b = Int32.Parse(s[1]);
            char[,] chars = new char[a, b];
            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    chars[j, i] = '*';
                    Console.Write(chars[j, i]);
                }
                Console.WriteLine();
            }
    }
}