using System;

namespace P5.PrintPartOfASCIITable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startIndex = int.Parse(Console.ReadLine());
            int endIndex = int.Parse(Console.ReadLine());

            for (int i = startIndex; i <= endIndex; i++)
            {
                char character = (char)i;
                Console.Write($"{character} ");
            }

            Console.WriteLine();
        }
    }
}
