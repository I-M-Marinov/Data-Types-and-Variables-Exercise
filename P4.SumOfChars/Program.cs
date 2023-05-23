using System;

namespace P4.SumOfChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                char character = Console.ReadLine()[0];
                sum += (int)character;
            }

            Console.WriteLine($"The sum equals: {sum}");
           
        }
    }
}
