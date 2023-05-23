using System;

namespace P1.IntegerOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());

            int sum = num1 + num2;
            double division = (int)sum/num3;
            double multiplication = (int)division*num4;

            Console.WriteLine(multiplication);
        }
    }
}
