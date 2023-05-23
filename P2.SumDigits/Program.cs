using System;
using System.Drawing;

namespace P2.SumDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            string inputToString = inputNumber.ToString();
            int numberOfDigits = inputToString.Length;
            int sum = 0;
             

            for (int i = 0; i <= numberOfDigits; i++)
            {
                
                while (inputNumber > 0)
                {
                    int lastDigit = inputNumber % 10;
                    inputNumber = inputNumber / 10;
                    sum += lastDigit;
                }

            }

            Console.WriteLine(sum);
        }
    }
}
